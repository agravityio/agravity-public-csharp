/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.3.0
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace Agravity.Public.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static class ClientUtils
    {
        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");
            return match.Success ? match.Groups[1].Value : filename;
        }

        /// <summary>
        /// Convert params to key/value pairs.
        /// Use collectionFormat to properly format lists and collections.
        /// </summary>
        /// <param name="collectionFormat">The swagger-supported collection format, one of: csv, tsv, ssv, pipes, multi</param>
        /// <param name="name">Key name.</param>
        /// <param name="value">Value object.</param>
        /// <returns>A multimap of keys with 1..n associated values.</returns>
        public static Multimap<string, string> ParameterToMultiMap(string collectionFormat, string name, object value)
        {
            var parameters = new Multimap<string, string>();

            if (value is ICollection collection && collectionFormat == "multi")
            {
                foreach (var item in collection)
                {
                    parameters.Add(name, ParameterToString(item));
                }
            }
            else if (value is IDictionary dictionary)
            {
                if(collectionFormat == "deepObject") {
                    foreach (DictionaryEntry entry in dictionary)
                    {
                        parameters.Add(name + "[" + entry.Key + "]", ParameterToString(entry.Value));
                    }
                }
                else {
                    foreach (DictionaryEntry entry in dictionary)
                    {
                        parameters.Add(entry.Key.ToString(), ParameterToString(entry.Value));
                    }
                }
            }
            else
            {
                parameters.Add(name, ParameterToString(value));
            }

            return parameters;
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="configuration">An optional configuration instance, providing formatting options used in processing.</param>
        /// <returns>Formatted string.</returns>
        public static string ParameterToString(object obj, IReadableConfiguration configuration = null)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString((configuration ?? GlobalConfiguration.Instance).DateTimeFormat);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString((configuration ?? GlobalConfiguration.Instance).DateTimeFormat);
            if (obj is bool boolean)
                return boolean ? "true" : "false";
            if (obj is ICollection collection)
                return string.Join(",", collection.Cast<object>());
            if (obj is Enum && HasEnumMemberAttrValue(obj))
                return GetEnumMemberAttrValue(obj);

            return Convert.ToString(obj, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Serializes the given object when not null. Otherwise return null.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>Serialized string.</returns>
        public static string Serialize(object obj)
        {
            return obj != null ? Newtonsoft.Json.JsonConvert.SerializeObject(obj) : null;
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        public static readonly Regex JsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json");
        }

        /// <summary>
        /// Is the Enum decorated with EnumMember Attribute
        /// </summary>
        /// <param name="enumVal"></param>
        /// <returns>true if found</returns>
        private static bool HasEnumMemberAttrValue(object enumVal)
        {
            if (enumVal == null)
                throw new ArgumentNullException(nameof(enumVal));
            var enumType = enumVal.GetType();
            var memInfo = enumType.GetMember(enumVal.ToString() ?? throw new InvalidOperationException());
            var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();
            if (attr != null) return true;
                return false;
        }

        /// <summary>
        /// Get the EnumMember value
        /// </summary>
        /// <param name="enumVal"></param>
        /// <returns>EnumMember value as string otherwise null</returns>
        private static string GetEnumMemberAttrValue(object enumVal)
        {
            if (enumVal == null)
                throw new ArgumentNullException(nameof(enumVal));
            var enumType = enumVal.GetType();
            var memInfo = enumType.GetMember(enumVal.ToString() ?? throw new InvalidOperationException());
            var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();
            if (attr != null)
            {
                return attr.Value;
            }
            return null;
        }
    }
}

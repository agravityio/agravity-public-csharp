/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.0.0-preview.1
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Agravity.Public.Client.OpenAPIDateConverter;

namespace Agravity.Public.Model
{
    /// <summary>
    /// AssetBlob
    /// </summary>
    [DataContract(Name = "assetBlob")]
    public partial class AssetBlob : IValidatableObject
    {
        /// <summary>
        /// Defines BlobType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlobTypeEnum
        {
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,

            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            [EnumMember(Value = "IMAGE")]
            IMAGE,

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            [EnumMember(Value = "VIDEO")]
            VIDEO,

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            [EnumMember(Value = "AUDIO")]
            AUDIO,

            /// <summary>
            /// Enum DOCUMENT for value: DOCUMENT
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            DOCUMENT,

            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            [EnumMember(Value = "TEXT")]
            TEXT,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER
        }


        /// <summary>
        /// Gets or Sets BlobType
        /// </summary>
        [DataMember(Name = "blob_type", EmitDefaultValue = false)]
        public BlobTypeEnum? BlobType { get; set; }
        /// <summary>
        /// Defines Orientation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationEnum
        {
            /// <summary>
            /// Enum PORTRAIT for value: PORTRAIT
            /// </summary>
            [EnumMember(Value = "PORTRAIT")]
            PORTRAIT = 1,

            /// <summary>
            /// Enum LANDSCAPE for value: LANDSCAPE
            /// </summary>
            [EnumMember(Value = "LANDSCAPE")]
            LANDSCAPE = 2,

            /// <summary>
            /// Enum SQUARE for value: SQUARE
            /// </summary>
            [EnumMember(Value = "SQUARE")]
            SQUARE = 3
        }


        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name = "orientation", EmitDefaultValue = true)]
        public OrientationEnum? Orientation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetBlob" /> class.
        /// </summary>
        /// <param name="blobType">blobType (default to BlobTypeEnum.UNKNOWN).</param>
        /// <param name="name">name.</param>
        /// <param name="container">container.</param>
        /// <param name="size">size.</param>
        /// <param name="extension">extension.</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="md5">md5.</param>
        /// <param name="addData">addData.</param>
        /// <param name="width">width.</param>
        /// <param name="height">height.</param>
        /// <param name="maxwidthheight">maxwidthheight.</param>
        /// <param name="quality">quality.</param>
        /// <param name="orientation">orientation (default to OrientationEnum.PORTRAIT).</param>
        /// <param name="colorspace">colorspace.</param>
        /// <param name="profile">profile.</param>
        /// <param name="transparency">transparency.</param>
        /// <param name="mode">mode.</param>
        /// <param name="target">target.</param>
        /// <param name="filter">filter.</param>
        /// <param name="dpiX">dpiX.</param>
        /// <param name="dpiY">dpiY.</param>
        /// <param name="perhash">perhash.</param>
        /// <param name="dominantcolor">dominantcolor.</param>
        /// <param name="depth">depth.</param>
        /// <param name="animated">animated.</param>
        /// <param name="duration">duration.</param>
        /// <param name="videocodec">videocodec.</param>
        /// <param name="videobitrate">videobitrate.</param>
        /// <param name="fps">fps.</param>
        /// <param name="colormode">colormode.</param>
        /// <param name="audiocodec">audiocodec.</param>
        /// <param name="audiosamplerate">audiosamplerate.</param>
        /// <param name="audiochanneloutput">audiochanneloutput.</param>
        /// <param name="audiobitrate">audiobitrate.</param>
        /// <param name="author">author.</param>
        /// <param name="title">title.</param>
        /// <param name="language">language.</param>
        /// <param name="wordcount">wordcount.</param>
        /// <param name="pages">pages.</param>
        /// <param name="encodingName">encodingName.</param>
        /// <param name="encodingCode">encodingCode.</param>
        /// <param name="url">url.</param>
        /// <param name="sizeReadable">sizeReadable.</param>
        /// <param name="downloadable">downloadable.</param>
        /// <param name="expires">expires.</param>
        /// <param name="uploadedDate">uploadedDate.</param>
        /// <param name="uploadedBy">uploadedBy.</param>
        public AssetBlob(BlobTypeEnum? blobType = BlobTypeEnum.UNKNOWN, string name = default(string), string container = default(string), long? size = default(long?), string extension = default(string), string contentType = default(string), string md5 = default(string), Dictionary<string, object> addData = default(Dictionary<string, object>), int? width = default(int?), int? height = default(int?), int? maxwidthheight = default(int?), double? quality = default(double?), OrientationEnum? orientation = OrientationEnum.PORTRAIT, string colorspace = default(string), string profile = default(string), bool? transparency = default(bool?), string mode = default(string), string target = default(string), string filter = default(string), double? dpiX = default(double?), double? dpiY = default(double?), string perhash = default(string), string dominantcolor = default(string), int? depth = default(int?), bool? animated = default(bool?), int? duration = default(int?), string videocodec = default(string), int? videobitrate = default(int?), double? fps = default(double?), string colormode = default(string), string audiocodec = default(string), string audiosamplerate = default(string), string audiochanneloutput = default(string), int? audiobitrate = default(int?), string author = default(string), string title = default(string), string language = default(string), int? wordcount = default(int?), int? pages = default(int?), string encodingName = default(string), string encodingCode = default(string), string url = default(string), string sizeReadable = default(string), bool? downloadable = default(bool?), DateTime? expires = default(DateTime?), DateTime? uploadedDate = default(DateTime?), string uploadedBy = default(string))
        {
            this.BlobType = blobType;
            this.Name = name;
            this.Container = container;
            this.Size = size;
            this.Extension = extension;
            this.ContentType = contentType;
            this.Md5 = md5;
            this.AddData = addData;
            this.Width = width;
            this.Height = height;
            this.Maxwidthheight = maxwidthheight;
            this.Quality = quality;
            this.Orientation = orientation;
            this.Colorspace = colorspace;
            this.Profile = profile;
            this.Transparency = transparency;
            this.Mode = mode;
            this.Target = target;
            this.Filter = filter;
            this.DpiX = dpiX;
            this.DpiY = dpiY;
            this.Perhash = perhash;
            this.Dominantcolor = dominantcolor;
            this.Depth = depth;
            this.Animated = animated;
            this.Duration = duration;
            this.Videocodec = videocodec;
            this.Videobitrate = videobitrate;
            this.Fps = fps;
            this.Colormode = colormode;
            this.Audiocodec = audiocodec;
            this.Audiosamplerate = audiosamplerate;
            this.Audiochanneloutput = audiochanneloutput;
            this.Audiobitrate = audiobitrate;
            this.Author = author;
            this.Title = title;
            this.Language = language;
            this.Wordcount = wordcount;
            this.Pages = pages;
            this.EncodingName = encodingName;
            this.EncodingCode = encodingCode;
            this.Url = url;
            this.SizeReadable = sizeReadable;
            this.Downloadable = downloadable;
            this.Expires = expires;
            this.UploadedDate = uploadedDate;
            this.UploadedBy = uploadedBy;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [DataMember(Name = "container", EmitDefaultValue = true)]
        public string Container { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public long? Size { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name = "extension", EmitDefaultValue = true)]
        public string Extension { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "content_type", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name = "md5", EmitDefaultValue = true)]
        public string Md5 { get; set; }

        /// <summary>
        /// Gets or Sets AddData
        /// </summary>
        [DataMember(Name = "add_data", EmitDefaultValue = true)]
        public Dictionary<string, object> AddData { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = true)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = true)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or Sets Maxwidthheight
        /// </summary>
        [DataMember(Name = "maxwidthheight", EmitDefaultValue = true)]
        public int? Maxwidthheight { get; set; }

        /// <summary>
        /// Gets or Sets Quality
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = true)]
        public double? Quality { get; set; }

        /// <summary>
        /// Gets or Sets Colorspace
        /// </summary>
        [DataMember(Name = "colorspace", EmitDefaultValue = true)]
        public string Colorspace { get; set; }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = true)]
        public string Profile { get; set; }

        /// <summary>
        /// Gets or Sets Transparency
        /// </summary>
        [DataMember(Name = "transparency", EmitDefaultValue = true)]
        public bool? Transparency { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", EmitDefaultValue = true)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", EmitDefaultValue = true)]
        public string Target { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets DpiX
        /// </summary>
        [DataMember(Name = "dpi_x", EmitDefaultValue = true)]
        public double? DpiX { get; set; }

        /// <summary>
        /// Gets or Sets DpiY
        /// </summary>
        [DataMember(Name = "dpi_y", EmitDefaultValue = true)]
        public double? DpiY { get; set; }

        /// <summary>
        /// Gets or Sets Perhash
        /// </summary>
        [DataMember(Name = "perhash", EmitDefaultValue = true)]
        public string Perhash { get; set; }

        /// <summary>
        /// Gets or Sets Dominantcolor
        /// </summary>
        [DataMember(Name = "dominantcolor", EmitDefaultValue = true)]
        public string Dominantcolor { get; set; }

        /// <summary>
        /// Gets or Sets Depth
        /// </summary>
        [DataMember(Name = "depth", EmitDefaultValue = true)]
        public int? Depth { get; set; }

        /// <summary>
        /// Gets or Sets Animated
        /// </summary>
        [DataMember(Name = "animated", EmitDefaultValue = true)]
        public bool? Animated { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name = "duration", EmitDefaultValue = true)]
        public int? Duration { get; set; }

        /// <summary>
        /// Gets or Sets Videocodec
        /// </summary>
        [DataMember(Name = "videocodec", EmitDefaultValue = true)]
        public string Videocodec { get; set; }

        /// <summary>
        /// Gets or Sets Videobitrate
        /// </summary>
        [DataMember(Name = "videobitrate", EmitDefaultValue = true)]
        public int? Videobitrate { get; set; }

        /// <summary>
        /// Gets or Sets Fps
        /// </summary>
        [DataMember(Name = "fps", EmitDefaultValue = true)]
        public double? Fps { get; set; }

        /// <summary>
        /// Gets or Sets Colormode
        /// </summary>
        [DataMember(Name = "colormode", EmitDefaultValue = true)]
        public string Colormode { get; set; }

        /// <summary>
        /// Gets or Sets Audiocodec
        /// </summary>
        [DataMember(Name = "audiocodec", EmitDefaultValue = true)]
        public string Audiocodec { get; set; }

        /// <summary>
        /// Gets or Sets Audiosamplerate
        /// </summary>
        [DataMember(Name = "audiosamplerate", EmitDefaultValue = true)]
        public string Audiosamplerate { get; set; }

        /// <summary>
        /// Gets or Sets Audiochanneloutput
        /// </summary>
        [DataMember(Name = "audiochanneloutput", EmitDefaultValue = true)]
        public string Audiochanneloutput { get; set; }

        /// <summary>
        /// Gets or Sets Audiobitrate
        /// </summary>
        [DataMember(Name = "audiobitrate", EmitDefaultValue = true)]
        public int? Audiobitrate { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Wordcount
        /// </summary>
        [DataMember(Name = "wordcount", EmitDefaultValue = true)]
        public int? Wordcount { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name = "pages", EmitDefaultValue = true)]
        public int? Pages { get; set; }

        /// <summary>
        /// Gets or Sets EncodingName
        /// </summary>
        [DataMember(Name = "encoding_name", EmitDefaultValue = true)]
        public string EncodingName { get; set; }

        /// <summary>
        /// Gets or Sets EncodingCode
        /// </summary>
        [DataMember(Name = "encoding_code", EmitDefaultValue = true)]
        public string EncodingCode { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets SizeReadable
        /// </summary>
        [DataMember(Name = "size_readable", EmitDefaultValue = true)]
        public string SizeReadable { get; set; }

        /// <summary>
        /// Gets or Sets Downloadable
        /// </summary>
        [DataMember(Name = "downloadable", EmitDefaultValue = true)]
        public bool? Downloadable { get; set; }

        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name = "expires", EmitDefaultValue = true)]
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets or Sets UploadedDate
        /// </summary>
        [DataMember(Name = "uploaded_date", EmitDefaultValue = true)]
        public DateTime? UploadedDate { get; set; }

        /// <summary>
        /// Gets or Sets UploadedBy
        /// </summary>
        [DataMember(Name = "uploaded_by", EmitDefaultValue = true)]
        public string UploadedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssetBlob {\n");
            sb.Append("  BlobType: ").Append(BlobType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  AddData: ").Append(AddData).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Maxwidthheight: ").Append(Maxwidthheight).Append("\n");
            sb.Append("  Quality: ").Append(Quality).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  Colorspace: ").Append(Colorspace).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Transparency: ").Append(Transparency).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  DpiX: ").Append(DpiX).Append("\n");
            sb.Append("  DpiY: ").Append(DpiY).Append("\n");
            sb.Append("  Perhash: ").Append(Perhash).Append("\n");
            sb.Append("  Dominantcolor: ").Append(Dominantcolor).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Animated: ").Append(Animated).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Videocodec: ").Append(Videocodec).Append("\n");
            sb.Append("  Videobitrate: ").Append(Videobitrate).Append("\n");
            sb.Append("  Fps: ").Append(Fps).Append("\n");
            sb.Append("  Colormode: ").Append(Colormode).Append("\n");
            sb.Append("  Audiocodec: ").Append(Audiocodec).Append("\n");
            sb.Append("  Audiosamplerate: ").Append(Audiosamplerate).Append("\n");
            sb.Append("  Audiochanneloutput: ").Append(Audiochanneloutput).Append("\n");
            sb.Append("  Audiobitrate: ").Append(Audiobitrate).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Wordcount: ").Append(Wordcount).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  EncodingName: ").Append(EncodingName).Append("\n");
            sb.Append("  EncodingCode: ").Append(EncodingCode).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  SizeReadable: ").Append(SizeReadable).Append("\n");
            sb.Append("  Downloadable: ").Append(Downloadable).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  UploadedDate: ").Append(UploadedDate).Append("\n");
            sb.Append("  UploadedBy: ").Append(UploadedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

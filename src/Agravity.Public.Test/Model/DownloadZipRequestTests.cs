/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 9.0.0
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Agravity.Public.Model;
using Agravity.Public.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Agravity.Public.Test.Model
{
    /// <summary>
    ///  Class for testing DownloadZipRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DownloadZipRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DownloadZipRequest
        //private DownloadZipRequest instance;

        public DownloadZipRequestTests()
        {
            // TODO uncomment below to create an instance of DownloadZipRequest
            //instance = new DownloadZipRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DownloadZipRequest
        /// </summary>
        [Fact]
        public void DownloadZipRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" DownloadZipRequest
            //Assert.IsType<DownloadZipRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'ZipType'
        /// </summary>
        [Fact]
        public void ZipTypeTest()
        {
            // TODO unit test for the property 'ZipType'
        }

        /// <summary>
        /// Test the property 'AssetIds'
        /// </summary>
        [Fact]
        public void AssetIdsTest()
        {
            // TODO unit test for the property 'AssetIds'
        }

        /// <summary>
        /// Test the property 'AllowedFormats'
        /// </summary>
        [Fact]
        public void AllowedFormatsTest()
        {
            // TODO unit test for the property 'AllowedFormats'
        }

        /// <summary>
        /// Test the property 'Zipname'
        /// </summary>
        [Fact]
        public void ZipnameTest()
        {
            // TODO unit test for the property 'Zipname'
        }

        /// <summary>
        /// Test the property 'EmailTo'
        /// </summary>
        [Fact]
        public void EmailToTest()
        {
            // TODO unit test for the property 'EmailTo'
        }

        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

        /// <summary>
        /// Test the property 'ValidUntil'
        /// </summary>
        [Fact]
        public void ValidUntilTest()
        {
            // TODO unit test for the property 'ValidUntil'
        }
    }
}

/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.2.0
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Agravity.Public.Api;
using Agravity.Public.Model;
using Agravity.Public.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Agravity.Public.Test.Model
{
    /// <summary>
    ///  Class for testing SharedAsset
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SharedAssetTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SharedAsset
        //private SharedAsset instance;

        public SharedAssetTests()
        {
            // TODO uncomment below to create an instance of SharedAsset
            //instance = new SharedAsset();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SharedAsset
        /// </summary>
        [Fact]
        public void SharedAssetInstanceTest()
        {
            // TODO uncomment below to test "IsType" SharedAsset
            //Assert.IsType<SharedAsset>(instance);
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
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'CreatedDate'
        /// </summary>
        [Fact]
        public void CreatedDateTest()
        {
            // TODO unit test for the property 'CreatedDate'
        }
        /// <summary>
        /// Test the property 'ModifiedDate'
        /// </summary>
        [Fact]
        public void ModifiedDateTest()
        {
            // TODO unit test for the property 'ModifiedDate'
        }
        /// <summary>
        /// Test the property 'AssetType'
        /// </summary>
        [Fact]
        public void AssetTypeTest()
        {
            // TODO unit test for the property 'AssetType'
        }
        /// <summary>
        /// Test the property 'OrigBlob'
        /// </summary>
        [Fact]
        public void OrigBlobTest()
        {
            // TODO unit test for the property 'OrigBlob'
        }
        /// <summary>
        /// Test the property 'Blobs'
        /// </summary>
        [Fact]
        public void BlobsTest()
        {
            // TODO unit test for the property 'Blobs'
        }

    }

}

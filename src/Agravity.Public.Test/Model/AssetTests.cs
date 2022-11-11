/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 4.7.3
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
    ///  Class for testing Asset
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AssetTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Asset
        //private Asset instance;

        public AssetTests()
        {
            // TODO uncomment below to create an instance of Asset
            //instance = new Asset();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Asset
        /// </summary>
        [Fact]
        public void AssetInstanceTest()
        {
            // TODO uncomment below to test "IsType" Asset
            //Assert.IsType<Asset>(instance);
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
        /// Test the property 'EntityType'
        /// </summary>
        [Fact]
        public void EntityTypeTest()
        {
            // TODO unit test for the property 'EntityType'
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
        /// Test the property 'AssetType'
        /// </summary>
        [Fact]
        public void AssetTypeTest()
        {
            // TODO unit test for the property 'AssetType'
        }
        /// <summary>
        /// Test the property 'Access'
        /// </summary>
        [Fact]
        public void AccessTest()
        {
            // TODO unit test for the property 'Access'
        }
        /// <summary>
        /// Test the property 'Duplicates'
        /// </summary>
        [Fact]
        public void DuplicatesTest()
        {
            // TODO unit test for the property 'Duplicates'
        }
        /// <summary>
        /// Test the property 'TextContent'
        /// </summary>
        [Fact]
        public void TextContentTest()
        {
            // TODO unit test for the property 'TextContent'
        }
        /// <summary>
        /// Test the property 'AiGroups'
        /// </summary>
        [Fact]
        public void AiGroupsTest()
        {
            // TODO unit test for the property 'AiGroups'
        }
        /// <summary>
        /// Test the property 'Keywords'
        /// </summary>
        [Fact]
        public void KeywordsTest()
        {
            // TODO unit test for the property 'Keywords'
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
        /// <summary>
        /// Test the property 'Collections'
        /// </summary>
        [Fact]
        public void CollectionsTest()
        {
            // TODO unit test for the property 'Collections'
        }
        /// <summary>
        /// Test the property 'FailedReason'
        /// </summary>
        [Fact]
        public void FailedReasonTest()
        {
            // TODO unit test for the property 'FailedReason'
        }
        /// <summary>
        /// Test the property 'Permissions'
        /// </summary>
        [Fact]
        public void PermissionsTest()
        {
            // TODO unit test for the property 'Permissions'
        }
        /// <summary>
        /// Test the property 'RegionOfOrigin'
        /// </summary>
        [Fact]
        public void RegionOfOriginTest()
        {
            // TODO unit test for the property 'RegionOfOrigin'
        }
        /// <summary>
        /// Test the property 'Availability'
        /// </summary>
        [Fact]
        public void AvailabilityTest()
        {
            // TODO unit test for the property 'Availability'
        }
        /// <summary>
        /// Test the property 'AvailableFrom'
        /// </summary>
        [Fact]
        public void AvailableFromTest()
        {
            // TODO unit test for the property 'AvailableFrom'
        }
        /// <summary>
        /// Test the property 'AvailableTo'
        /// </summary>
        [Fact]
        public void AvailableToTest()
        {
            // TODO unit test for the property 'AvailableTo'
        }
        /// <summary>
        /// Test the property 'Custom'
        /// </summary>
        [Fact]
        public void CustomTest()
        {
            // TODO unit test for the property 'Custom'
        }
        /// <summary>
        /// Test the property 'Items'
        /// </summary>
        [Fact]
        public void ItemsTest()
        {
            // TODO unit test for the property 'Items'
        }
        /// <summary>
        /// Test the property 'Translations'
        /// </summary>
        [Fact]
        public void TranslationsTest()
        {
            // TODO unit test for the property 'Translations'
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
        /// Test the property 'AddProperties'
        /// </summary>
        [Fact]
        public void AddPropertiesTest()
        {
            // TODO unit test for the property 'AddProperties'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
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
        /// Test the property 'CreatedBy'
        /// </summary>
        [Fact]
        public void CreatedByTest()
        {
            // TODO unit test for the property 'CreatedBy'
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
        /// Test the property 'ModifiedBy'
        /// </summary>
        [Fact]
        public void ModifiedByTest()
        {
            // TODO unit test for the property 'ModifiedBy'
        }
        /// <summary>
        /// Test the property 'Pk'
        /// </summary>
        [Fact]
        public void PkTest()
        {
            // TODO unit test for the property 'Pk'
        }
        /// <summary>
        /// Test the property 'Etag'
        /// </summary>
        [Fact]
        public void EtagTest()
        {
            // TODO unit test for the property 'Etag'
        }

    }

}

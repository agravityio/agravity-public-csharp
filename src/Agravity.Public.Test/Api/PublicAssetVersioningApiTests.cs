/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 6.0.1
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Agravity.Public.Client;
using Agravity.Public.Api;
// uncomment below to import models
//using Agravity.Public.Model;

namespace Agravity.Public.Test.Api
{
    /// <summary>
    ///  Class for testing PublicAssetVersioningApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicAssetVersioningApiTests : IDisposable
    {
        private PublicAssetVersioningApi instance;

        public PublicAssetVersioningApiTests()
        {
            instance = new PublicAssetVersioningApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicAssetVersioningApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicAssetVersioningApi
            //Assert.IsType<PublicAssetVersioningApi>(instance);
        }

        /// <summary>
        /// Test HttpAssetCreateUploadVersion
        /// </summary>
        [Fact]
        public void HttpAssetCreateUploadVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string name = null;
            //string collectionId = null;
            //System.IO.Stream file = null;
            //string filename = null;
            //string previewof = null;
            //var response = instance.HttpAssetCreateUploadVersion(id, name, collectionId, file, filename, previewof);
            //Assert.IsType<VersionedAsset>(response);
        }

        /// <summary>
        /// Test HttpAssetCreateVersion
        /// </summary>
        [Fact]
        public void HttpAssetCreateVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //VersionedAsset versionedAsset = null;
            //var response = instance.HttpAssetCreateVersion(id, versionedAsset);
            //Assert.IsType<VersionedAsset>(response);
        }

        /// <summary>
        /// Test HttpDeleteVersionedAssetsById
        /// </summary>
        [Fact]
        public void HttpDeleteVersionedAssetsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string vNr = null;
            //instance.HttpDeleteVersionedAssetsById(id, vNr);
        }

        /// <summary>
        /// Test HttpGetVersionedAssetBlobById
        /// </summary>
        [Fact]
        public void HttpGetVersionedAssetBlobByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int vNr = null;
            //string c = null;
            //var response = instance.HttpGetVersionedAssetBlobById(id, vNr, c);
            //Assert.IsType<AssetBlob>(response);
        }

        /// <summary>
        /// Test HttpRestoreVersionedAssetsById
        /// </summary>
        [Fact]
        public void HttpRestoreVersionedAssetsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string vNr = null;
            //VersionedAsset versionedAsset = null;
            //var response = instance.HttpRestoreVersionedAssetsById(id, vNr, versionedAsset);
            //Assert.IsType<VersionedAsset>(response);
        }

        /// <summary>
        /// Test HttpUpdateVersionedAssetsById
        /// </summary>
        [Fact]
        public void HttpUpdateVersionedAssetsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string vNr = null;
            //instance.HttpUpdateVersionedAssetsById(id, vNr);
        }

        /// <summary>
        /// Test HttpVersionedAssetsGet
        /// </summary>
        [Fact]
        public void HttpVersionedAssetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.HttpVersionedAssetsGet(id);
            //Assert.IsType<VersionEntity>(response);
        }
    }
}

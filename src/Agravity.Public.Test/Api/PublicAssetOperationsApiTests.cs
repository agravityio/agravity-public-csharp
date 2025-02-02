/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.4.2
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
    ///  Class for testing PublicAssetOperationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicAssetOperationsApiTests : IDisposable
    {
        private PublicAssetOperationsApi instance;

        public PublicAssetOperationsApiTests()
        {
            instance = new PublicAssetOperationsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicAssetOperationsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicAssetOperationsApi
            //Assert.IsType<PublicAssetOperationsApi>(instance);
        }

        /// <summary>
        /// Test HttpAssetImageEdit
        /// </summary>
        [Fact]
        public void HttpAssetImageEditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? width = null;
            //int? height = null;
            //string mode = null;
            //string target = null;
            //string bgcolor = null;
            //int? dpi = null;
            //int? depth = null;
            //int? quality = null;
            //string colorspace = null;
            //int? cropX = null;
            //int? cropY = null;
            //int? cropWidth = null;
            //int? cropHeight = null;
            //string filter = null;
            //bool? original = null;
            //var response = instance.HttpAssetImageEdit(id, width, height, mode, target, bgcolor, dpi, depth, quality, colorspace, cropX, cropY, cropWidth, cropHeight, filter, original);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test HttpAssetResize
        /// </summary>
        [Fact]
        public void HttpAssetResizeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.HttpAssetResize(id);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test HttpAssetToCollection
        /// </summary>
        [Fact]
        public void HttpAssetToCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //MoveCollectionBody moveCollectionBody = null;
            //instance.HttpAssetToCollection(id, moveCollectionBody);
        }

        /// <summary>
        /// Test HttpGetAssetBlob
        /// </summary>
        [Fact]
        public void HttpGetAssetBlobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string c = null;
            //string portalId = null;
            //string key = null;
            //var response = instance.HttpGetAssetBlob(id, c, portalId, key);
            //Assert.IsType<AssetBlob>(response);
        }

        /// <summary>
        /// Test HttpGetAssetCollectionsById
        /// </summary>
        [Fact]
        public void HttpGetAssetCollectionsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fields = null;
            //bool? translations = null;
            //string acceptLanguage = null;
            //var response = instance.HttpGetAssetCollectionsById(id, fields, translations, acceptLanguage);
            //Assert.IsType<List<Collection>>(response);
        }

        /// <summary>
        /// Test HttpGetAssetDownload
        /// </summary>
        [Fact]
        public void HttpGetAssetDownloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string c = null;
            //string f = null;
            //string portalId = null;
            //string key = null;
            //var response = instance.HttpGetAssetDownload(id, c, f, portalId, key);
            //Assert.IsType<AssetBlob>(response);
        }

        /// <summary>
        /// Test HttpGetSharedAssetBlob
        /// </summary>
        [Fact]
        public void HttpGetSharedAssetBlobTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string shareId = null;
            //string id = null;
            //string format = null;
            //string ayPassword = null;
            //var response = instance.HttpGetSharedAssetBlob(shareId, id, format, ayPassword);
            //Assert.IsType<AssetBlob>(response);
        }

        /// <summary>
        /// Test HttpImageDynamicEdit
        /// </summary>
        [Fact]
        public void HttpImageDynamicEditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<DynamicImageOperation> dynamicImageOperation = null;
            //var response = instance.HttpImageDynamicEdit(id, dynamicImageOperation);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test HttpImageDynamicGetFromDownloadId
        /// </summary>
        [Fact]
        public void HttpImageDynamicGetFromDownloadIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string downloadFormatId = null;
            //var response = instance.HttpImageDynamicGetFromDownloadId(id, downloadFormatId);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test HttpPutAssetAvailability
        /// </summary>
        [Fact]
        public void HttpPutAssetAvailabilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //AssetAvailability assetAvailability = null;
            //var response = instance.HttpPutAssetAvailability(id, assetAvailability);
            //Assert.IsType<AssetAvailability>(response);
        }
    }
}

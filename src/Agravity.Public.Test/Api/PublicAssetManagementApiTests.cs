/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 9.3.0
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
    ///  Class for testing PublicAssetManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicAssetManagementApiTests : IDisposable
    {
        private PublicAssetManagementApi instance;

        public PublicAssetManagementApiTests()
        {
            instance = new PublicAssetManagementApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicAssetManagementApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicAssetManagementApi
            //Assert.IsType<PublicAssetManagementApi>(instance);
        }

        /// <summary>
        /// Test HttpAssetUploadFile
        /// </summary>
        [Fact]
        public void HttpAssetUploadFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptLanguage = null;
            //string name = null;
            //string collectionid = null;
            //System.IO.Stream file = null;
            //string filename = null;
            //string previewof = null;
            //var response = instance.HttpAssetUploadFile(acceptLanguage, name, collectionid, file, filename, previewof);
            //Assert.IsType<Asset>(response);
        }

        /// <summary>
        /// Test HttpAssetsCreate
        /// </summary>
        [Fact]
        public void HttpAssetsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionid = null;
            //Asset asset = null;
            //bool? translations = null;
            //string acceptLanguage = null;
            //var response = instance.HttpAssetsCreate(collectionid, asset, translations, acceptLanguage);
            //Assert.IsType<Asset>(response);
        }

        /// <summary>
        /// Test HttpAssetsGet
        /// </summary>
        [Fact]
        public void HttpAssetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectionid = null;
            //string collectiontypeid = null;
            //string fields = null;
            //bool? expose = null;
            //string continuationToken = null;
            //int? limit = null;
            //string orderby = null;
            //string filter = null;
            //bool? items = null;
            //bool? translations = null;
            //string acceptLanguage = null;
            //var response = instance.HttpAssetsGet(collectionid, collectiontypeid, fields, expose, continuationToken, limit, orderby, filter, items, translations, acceptLanguage);
            //Assert.IsType<AssetPageResult>(response);
        }

        /// <summary>
        /// Test HttpAssetsGetById
        /// </summary>
        [Fact]
        public void HttpAssetsGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fields = null;
            //bool? expose = null;
            //bool? translations = null;
            //string acceptLanguage = null;
            //var response = instance.HttpAssetsGetById(id, fields, expose, translations, acceptLanguage);
            //Assert.IsType<Asset>(response);
        }

        /// <summary>
        /// Test HttpPublicAssetsUpdateById
        /// </summary>
        [Fact]
        public void HttpPublicAssetsUpdateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Asset asset = null;
            //bool? translations = null;
            //string acceptLanguage = null;
            //var response = instance.HttpPublicAssetsUpdateById(id, asset, translations, acceptLanguage);
            //Assert.IsType<Asset>(response);
        }
    }
}

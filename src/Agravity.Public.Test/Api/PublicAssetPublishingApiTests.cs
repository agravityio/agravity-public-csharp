/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.1.3
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
    ///  Class for testing PublicAssetPublishingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicAssetPublishingApiTests : IDisposable
    {
        private PublicAssetPublishingApi instance;

        public PublicAssetPublishingApiTests()
        {
            instance = new PublicAssetPublishingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicAssetPublishingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicAssetPublishingApi
            //Assert.IsType<PublicAssetPublishingApi>(instance);
        }

        /// <summary>
        /// Test HttpPublishedAssetsCreate
        /// </summary>
        [Fact]
        public void HttpPublishedAssetsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //PublishedAsset publishedAsset = null;
            //var response = instance.HttpPublishedAssetsCreate(id, publishedAsset);
            //Assert.IsType<PublishedAsset>(response);
        }

        /// <summary>
        /// Test HttpPublishedAssetsGet
        /// </summary>
        [Fact]
        public void HttpPublishedAssetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.HttpPublishedAssetsGet(id);
            //Assert.IsType<PublishEntity>(response);
        }

        /// <summary>
        /// Test HttpPublishedAssetsGetById
        /// </summary>
        [Fact]
        public void HttpPublishedAssetsGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string pid = null;
            //var response = instance.HttpPublishedAssetsGetById(id, pid);
            //Assert.IsType<PublishedAsset>(response);
        }
    }
}

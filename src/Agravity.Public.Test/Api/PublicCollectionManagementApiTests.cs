/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.2.0
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
    ///  Class for testing PublicCollectionManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicCollectionManagementApiTests : IDisposable
    {
        private PublicCollectionManagementApi instance;

        public PublicCollectionManagementApiTests()
        {
            instance = new PublicCollectionManagementApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicCollectionManagementApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicCollectionManagementApi
            //Assert.IsType<PublicCollectionManagementApi>(instance);
        }

        /// <summary>
        /// Test HttpCollectionsCreate
        /// </summary>
        [Fact]
        public void HttpCollectionsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectiontypeid = null;
            //Collection collection = null;
            //var response = instance.HttpCollectionsCreate(collectiontypeid, collection);
            //Assert.IsType<Collection>(response);
        }

        /// <summary>
        /// Test HttpCollectionsGet
        /// </summary>
        [Fact]
        public void HttpCollectionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string collectiontypeid = null;
            //int? level = null;
            //string parentid = null;
            //string fields = null;
            //bool? items = null;
            //bool? translations = null;
            //var response = instance.HttpCollectionsGet(collectiontypeid, level, parentid, fields, items, translations);
            //Assert.IsType<List<Collection>>(response);
        }

        /// <summary>
        /// Test HttpCollectionsGetById
        /// </summary>
        [Fact]
        public void HttpCollectionsGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string fields = null;
            //bool? items = null;
            //bool? translations = null;
            //var response = instance.HttpCollectionsGetById(id, fields, items, translations);
            //Assert.IsType<Collection>(response);
        }

        /// <summary>
        /// Test HttpCollectionsGetDescendantsTreeOfId
        /// </summary>
        [Fact]
        public void HttpCollectionsGetDescendantsTreeOfIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? translations = null;
            //var response = instance.HttpCollectionsGetDescendantsTreeOfId(id, translations);
            //Assert.IsType<List<Collection>>(response);
        }

        /// <summary>
        /// Test HttpCollectionsGetTreeAncestorsOfId
        /// </summary>
        [Fact]
        public void HttpCollectionsGetTreeAncestorsOfIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //bool? translations = null;
            //var response = instance.HttpCollectionsGetTreeAncestorsOfId(id, translations);
            //Assert.IsType<List<Collection>>(response);
        }

        /// <summary>
        /// Test HttpGetCollectionPreviewsById
        /// </summary>
        [Fact]
        public void HttpGetCollectionPreviewsByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.HttpGetCollectionPreviewsById(id);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test HttpPublicCollectionsUpdateById
        /// </summary>
        [Fact]
        public void HttpPublicCollectionsUpdateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Collection collection = null;
            //bool? translations = null;
            //var response = instance.HttpPublicCollectionsUpdateById(id, collection, translations);
            //Assert.IsType<Collection>(response);
        }
    }
}

/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 9.3.0
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
    ///  Class for testing SharedCollectionFull
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SharedCollectionFullTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SharedCollectionFull
        //private SharedCollectionFull instance;

        public SharedCollectionFullTests()
        {
            // TODO uncomment below to create an instance of SharedCollectionFull
            //instance = new SharedCollectionFull();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SharedCollectionFull
        /// </summary>
        [Fact]
        public void SharedCollectionFullInstanceTest()
        {
            // TODO uncomment below to test "IsType" SharedCollectionFull
            //Assert.IsType<SharedCollectionFull>(instance);
        }

        /// <summary>
        /// Test the property 'Page'
        /// </summary>
        [Fact]
        public void PageTest()
        {
            // TODO unit test for the property 'Page'
        }

        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Fact]
        public void PageSizeTest()
        {
            // TODO unit test for the property 'PageSize'
        }

        /// <summary>
        /// Test the property 'Size'
        /// </summary>
        [Fact]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }

        /// <summary>
        /// Test the property 'ContinuationToken'
        /// </summary>
        [Fact]
        public void ContinuationTokenTest()
        {
            // TODO unit test for the property 'ContinuationToken'
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
        /// Test the property 'CollectionId'
        /// </summary>
        [Fact]
        public void CollectionIdTest()
        {
            // TODO unit test for the property 'CollectionId'
        }

        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }

        /// <summary>
        /// Test the property 'ValidUntil'
        /// </summary>
        [Fact]
        public void ValidUntilTest()
        {
            // TODO unit test for the property 'ValidUntil'
        }

        /// <summary>
        /// Test the property 'ValidFor'
        /// </summary>
        [Fact]
        public void ValidForTest()
        {
            // TODO unit test for the property 'ValidFor'
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
        /// Test the property 'Global'
        /// </summary>
        [Fact]
        public void GlobalTest()
        {
            // TODO unit test for the property 'Global'
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
        /// Test the property 'Password'
        /// </summary>
        [Fact]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
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

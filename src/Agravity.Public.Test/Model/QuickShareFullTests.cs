/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2025. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.4.1
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
    ///  Class for testing QuickShareFull
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QuickShareFullTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for QuickShareFull
        //private QuickShareFull instance;

        public QuickShareFullTests()
        {
            // TODO uncomment below to create an instance of QuickShareFull
            //instance = new QuickShareFull();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of QuickShareFull
        /// </summary>
        [Fact]
        public void QuickShareFullInstanceTest()
        {
            // TODO uncomment below to test "IsType" QuickShareFull
            //Assert.IsType<QuickShareFull>(instance);
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
        /// Test the property 'Assets'
        /// </summary>
        [Fact]
        public void AssetsTest()
        {
            // TODO unit test for the property 'Assets'
        }

        /// <summary>
        /// Test the property 'Users'
        /// </summary>
        [Fact]
        public void UsersTest()
        {
            // TODO unit test for the property 'Users'
        }

        /// <summary>
        /// Test the property 'Expires'
        /// </summary>
        [Fact]
        public void ExpiresTest()
        {
            // TODO unit test for the property 'Expires'
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
        /// Test the property 'ZipUrl'
        /// </summary>
        [Fact]
        public void ZipUrlTest()
        {
            // TODO unit test for the property 'ZipUrl'
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

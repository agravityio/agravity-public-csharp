/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.3.3
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
    ///  Class for testing PublishEntity
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PublishEntityTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PublishEntity
        //private PublishEntity instance;

        public PublishEntityTests()
        {
            // TODO uncomment below to create an instance of PublishEntity
            //instance = new PublishEntity();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublishEntity
        /// </summary>
        [Fact]
        public void PublishEntityInstanceTest()
        {
            // TODO uncomment below to test "IsType" PublishEntity
            //Assert.IsType<PublishEntity>(instance);
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
        /// Test the property 'Published'
        /// </summary>
        [Fact]
        public void PublishedTest()
        {
            // TODO unit test for the property 'Published'
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

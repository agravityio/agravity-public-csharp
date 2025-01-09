/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.3.1
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
    ///  Class for testing AzSearchOptions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AzSearchOptionsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AzSearchOptions
        //private AzSearchOptions instance;

        public AzSearchOptionsTests()
        {
            // TODO uncomment below to create an instance of AzSearchOptions
            //instance = new AzSearchOptions();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AzSearchOptions
        /// </summary>
        [Fact]
        public void AzSearchOptionsInstanceTest()
        {
            // TODO uncomment below to test "IsType" AzSearchOptions
            //Assert.IsType<AzSearchOptions>(instance);
        }

        /// <summary>
        /// Test the property 'SearchString'
        /// </summary>
        [Fact]
        public void SearchStringTest()
        {
            // TODO unit test for the property 'SearchString'
        }

        /// <summary>
        /// Test the property 'Limit'
        /// </summary>
        [Fact]
        public void LimitTest()
        {
            // TODO unit test for the property 'Limit'
        }

        /// <summary>
        /// Test the property 'Skip'
        /// </summary>
        [Fact]
        public void SkipTest()
        {
            // TODO unit test for the property 'Skip'
        }

        /// <summary>
        /// Test the property 'Collectiontypeid'
        /// </summary>
        [Fact]
        public void CollectiontypeidTest()
        {
            // TODO unit test for the property 'Collectiontypeid'
        }

        /// <summary>
        /// Test the property 'Collectionid'
        /// </summary>
        [Fact]
        public void CollectionidTest()
        {
            // TODO unit test for the property 'Collectionid'
        }

        /// <summary>
        /// Test the property 'Filter'
        /// </summary>
        [Fact]
        public void FilterTest()
        {
            // TODO unit test for the property 'Filter'
        }

        /// <summary>
        /// Test the property 'Orderby'
        /// </summary>
        [Fact]
        public void OrderbyTest()
        {
            // TODO unit test for the property 'Orderby'
        }

        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }

        /// <summary>
        /// Test the property 'Ids'
        /// </summary>
        [Fact]
        public void IdsTest()
        {
            // TODO unit test for the property 'Ids'
        }

        /// <summary>
        /// Test the property 'PortalId'
        /// </summary>
        [Fact]
        public void PortalIdTest()
        {
            // TODO unit test for the property 'PortalId'
        }

        /// <summary>
        /// Test the property 'Scopefilter'
        /// </summary>
        [Fact]
        public void ScopefilterTest()
        {
            // TODO unit test for the property 'Scopefilter'
        }
    }
}

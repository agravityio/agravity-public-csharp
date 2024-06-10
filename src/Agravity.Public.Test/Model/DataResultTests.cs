/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.2.2
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
    ///  Class for testing DataResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DataResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DataResult
        //private DataResult instance;

        public DataResultTests()
        {
            // TODO uncomment below to create an instance of DataResult
            //instance = new DataResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataResult
        /// </summary>
        [Fact]
        public void DataResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" DataResult
            //Assert.IsType<DataResult>(instance);
        }


        /// <summary>
        /// Test the property 'Asset'
        /// </summary>
        [Fact]
        public void AssetTest()
        {
            // TODO unit test for the property 'Asset'
        }
        /// <summary>
        /// Test the property 'SumAssetResults'
        /// </summary>
        [Fact]
        public void SumAssetResultsTest()
        {
            // TODO unit test for the property 'SumAssetResults'
        }
        /// <summary>
        /// Test the property 'Collection'
        /// </summary>
        [Fact]
        public void CollectionTest()
        {
            // TODO unit test for the property 'Collection'
        }
        /// <summary>
        /// Test the property 'SumCollectionResults'
        /// </summary>
        [Fact]
        public void SumCollectionResultsTest()
        {
            // TODO unit test for the property 'SumCollectionResults'
        }

    }

}

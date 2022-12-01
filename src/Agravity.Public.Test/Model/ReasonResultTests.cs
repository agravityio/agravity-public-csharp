/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 4.9.1
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
    ///  Class for testing ReasonResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReasonResultTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ReasonResult
        //private ReasonResult instance;

        public ReasonResultTests()
        {
            // TODO uncomment below to create an instance of ReasonResult
            //instance = new ReasonResult();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReasonResult
        /// </summary>
        [Fact]
        public void ReasonResultInstanceTest()
        {
            // TODO uncomment below to test "IsType" ReasonResult
            //Assert.IsType<ReasonResult>(instance);
        }


        /// <summary>
        /// Test the property 'Reason'
        /// </summary>
        [Fact]
        public void ReasonTest()
        {
            // TODO unit test for the property 'Reason'
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
        /// Test the property 'Ranking'
        /// </summary>
        [Fact]
        public void RankingTest()
        {
            // TODO unit test for the property 'Ranking'
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
        /// Test the property 'Ids'
        /// </summary>
        [Fact]
        public void IdsTest()
        {
            // TODO unit test for the property 'Ids'
        }

    }

}

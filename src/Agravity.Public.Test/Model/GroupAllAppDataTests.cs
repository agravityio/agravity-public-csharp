/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.0.0
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
    ///  Class for testing GroupAllAppData
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GroupAllAppDataTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for GroupAllAppData
        //private GroupAllAppData instance;

        public GroupAllAppDataTests()
        {
            // TODO uncomment below to create an instance of GroupAllAppData
            //instance = new GroupAllAppData();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupAllAppData
        /// </summary>
        [Fact]
        public void GroupAllAppDataInstanceTest()
        {
            // TODO uncomment below to test "IsType" GroupAllAppData
            //Assert.IsType<GroupAllAppData>(instance);
        }


        /// <summary>
        /// Test the property 'CollectionType'
        /// </summary>
        [Fact]
        public void CollectionTypeTest()
        {
            // TODO unit test for the property 'CollectionType'
        }
        /// <summary>
        /// Test the property 'Collections'
        /// </summary>
        [Fact]
        public void CollectionsTest()
        {
            // TODO unit test for the property 'Collections'
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
        /// Test the property 'CreatedDate'
        /// </summary>
        [Fact]
        public void CreatedDateTest()
        {
            // TODO unit test for the property 'CreatedDate'
        }
        /// <summary>
        /// Test the property 'AddInfo'
        /// </summary>
        [Fact]
        public void AddInfoTest()
        {
            // TODO unit test for the property 'AddInfo'
        }
        /// <summary>
        /// Test the property 'Dist'
        /// </summary>
        [Fact]
        public void DistTest()
        {
            // TODO unit test for the property 'Dist'
        }

    }

}

/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.3.0-usercontext.2
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
    ///  Class for testing SearchAdminIndexerStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SearchAdminIndexerStatusTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SearchAdminIndexerStatus
        //private SearchAdminIndexerStatus instance;

        public SearchAdminIndexerStatusTests()
        {
            // TODO uncomment below to create an instance of SearchAdminIndexerStatus
            //instance = new SearchAdminIndexerStatus();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchAdminIndexerStatus
        /// </summary>
        [Fact]
        public void SearchAdminIndexerStatusInstanceTest()
        {
            // TODO uncomment below to test "IsType" SearchAdminIndexerStatus
            //Assert.IsType<SearchAdminIndexerStatus>(instance);
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
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
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }

        /// <summary>
        /// Test the property 'Lastrun'
        /// </summary>
        [Fact]
        public void LastrunTest()
        {
            // TODO unit test for the property 'Lastrun'
        }

        /// <summary>
        /// Test the property 'History'
        /// </summary>
        [Fact]
        public void HistoryTest()
        {
            // TODO unit test for the property 'History'
        }
    }
}

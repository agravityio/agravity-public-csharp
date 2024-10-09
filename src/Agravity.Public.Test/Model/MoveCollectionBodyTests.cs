/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 8.1.1
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
    ///  Class for testing MoveCollectionBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MoveCollectionBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MoveCollectionBody
        //private MoveCollectionBody instance;

        public MoveCollectionBodyTests()
        {
            // TODO uncomment below to create an instance of MoveCollectionBody
            //instance = new MoveCollectionBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MoveCollectionBody
        /// </summary>
        [Fact]
        public void MoveCollectionBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" MoveCollectionBody
            //Assert.IsType<MoveCollectionBody>(instance);
        }

        /// <summary>
        /// Test the property 'FromCollectionId'
        /// </summary>
        [Fact]
        public void FromCollectionIdTest()
        {
            // TODO unit test for the property 'FromCollectionId'
        }

        /// <summary>
        /// Test the property 'ToCollectionId'
        /// </summary>
        [Fact]
        public void ToCollectionIdTest()
        {
            // TODO unit test for the property 'ToCollectionId'
        }

        /// <summary>
        /// Test the property 'Operation'
        /// </summary>
        [Fact]
        public void OperationTest()
        {
            // TODO unit test for the property 'Operation'
        }
    }
}

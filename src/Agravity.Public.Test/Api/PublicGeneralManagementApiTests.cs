/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.3.3
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
    ///  Class for testing PublicGeneralManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicGeneralManagementApiTests : IDisposable
    {
        private PublicGeneralManagementApi instance;

        public PublicGeneralManagementApiTests()
        {
            instance = new PublicGeneralManagementApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PublicGeneralManagementApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PublicGeneralManagementApi
            //Assert.IsType<PublicGeneralManagementApi>(instance);
        }

        /// <summary>
        /// Test HttpAgravityVersionInfo
        /// </summary>
        [Fact]
        public void HttpAgravityVersionInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.HttpAgravityVersionInfo();
            //Assert.IsType<AgravityVersion>(response);
        }

        /// <summary>
        /// Test HttpTriggerDurableContinue
        /// </summary>
        [Fact]
        public void HttpTriggerDurableContinueTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceId = null;
            //var response = instance.HttpTriggerDurableContinue(instanceId);
            //Assert.IsType<OkResult>(response);
        }

        /// <summary>
        /// Test HttpTriggerDurableScchTrainingDone
        /// </summary>
        [Fact]
        public void HttpTriggerDurableScchTrainingDoneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instanceId = null;
            //var response = instance.HttpTriggerDurableScchTrainingDone(instanceId);
            //Assert.IsType<OkResult>(response);
        }
    }
}

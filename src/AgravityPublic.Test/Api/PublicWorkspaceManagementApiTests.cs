/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 4.6.0
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
using NUnit.Framework;

using AgravityPublic.Client;
using AgravityPublic.Api;
using AgravityPublic.Model;

namespace AgravityPublic.Test
{
    /// <summary>
    ///  Class for testing PublicWorkspaceManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PublicWorkspaceManagementApiTests
    {
        private PublicWorkspaceManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublicWorkspaceManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PublicWorkspaceManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' PublicWorkspaceManagementApi
            //Assert.IsInstanceOf(typeof(PublicWorkspaceManagementApi), instance);
        }

        
        /// <summary>
        /// Test HttpWorkspacesGet
        /// </summary>
        [Test]
        public void HttpWorkspacesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.HttpWorkspacesGet();
            //Assert.IsInstanceOf(typeof(List<Workspace>), response, "response is List<Workspace>");
        }
        
        /// <summary>
        /// Test HttpWorkspacesGetById
        /// </summary>
        [Test]
        public void HttpWorkspacesGetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.HttpWorkspacesGetById(id);
            //Assert.IsInstanceOf(typeof(Workspace), response, "response is Workspace");
        }
        
    }

}

/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2022. All Rights Reserved
 *
 * The version of the OpenAPI document: 4.6.0
 * Contact: office@agravity.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using AgravityPublic.Api;
using AgravityPublic.Model;
using AgravityPublic.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace AgravityPublic.Test
{
    /// <summary>
    ///  Class for testing WhereParam
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class WhereParamTests
    {
        // TODO uncomment below to declare an instance variable for WhereParam
        //private WhereParam instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of WhereParam
            //instance = new WhereParam();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WhereParam
        /// </summary>
        [Test]
        public void WhereParamInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" WhereParam
            //Assert.IsInstanceOf(typeof(WhereParam), instance);
        }


        /// <summary>
        /// Test the property 'Operator'
        /// </summary>
        [Test]
        public void OperatorTest()
        {
            // TODO unit test for the property 'Operator'
        }
        /// <summary>
        /// Test the property 'Field'
        /// </summary>
        [Test]
        public void FieldTest()
        {
            // TODO unit test for the property 'Field'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

    }

}

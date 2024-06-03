/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 7.2.1
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
    ///  Class for testing PortalConfiguration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PortalConfigurationTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PortalConfiguration
        //private PortalConfiguration instance;

        public PortalConfigurationTests()
        {
            // TODO uncomment below to create an instance of PortalConfiguration
            //instance = new PortalConfiguration();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PortalConfiguration
        /// </summary>
        [Fact]
        public void PortalConfigurationInstanceTest()
        {
            // TODO uncomment below to test "IsType" PortalConfiguration
            //Assert.IsType<PortalConfiguration>(instance);
        }


        /// <summary>
        /// Test the property 'DownloadFormats'
        /// </summary>
        [Fact]
        public void DownloadFormatsTest()
        {
            // TODO unit test for the property 'DownloadFormats'
        }
        /// <summary>
        /// Test the property 'Sdls'
        /// </summary>
        [Fact]
        public void SdlsTest()
        {
            // TODO unit test for the property 'Sdls'
        }
        /// <summary>
        /// Test the property 'Udls'
        /// </summary>
        [Fact]
        public void UdlsTest()
        {
            // TODO unit test for the property 'Udls'
        }
        /// <summary>
        /// Test the property 'Items'
        /// </summary>
        [Fact]
        public void ItemsTest()
        {
            // TODO unit test for the property 'Items'
        }
        /// <summary>
        /// Test the property 'Configs'
        /// </summary>
        [Fact]
        public void ConfigsTest()
        {
            // TODO unit test for the property 'Configs'
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
        /// Test the property 'Filter'
        /// </summary>
        [Fact]
        public void FilterTest()
        {
            // TODO unit test for the property 'Filter'
        }
        /// <summary>
        /// Test the property 'Languages'
        /// </summary>
        [Fact]
        public void LanguagesTest()
        {
            // TODO unit test for the property 'Languages'
        }
        /// <summary>
        /// Test the property 'Theme'
        /// </summary>
        [Fact]
        public void ThemeTest()
        {
            // TODO unit test for the property 'Theme'
        }
        /// <summary>
        /// Test the property 'Links'
        /// </summary>
        [Fact]
        public void LinksTest()
        {
            // TODO unit test for the property 'Links'
        }
        /// <summary>
        /// Test the property 'Metadata'
        /// </summary>
        [Fact]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
        }
        /// <summary>
        /// Test the property 'Facettes'
        /// </summary>
        [Fact]
        public void FacettesTest()
        {
            // TODO unit test for the property 'Facettes'
        }
        /// <summary>
        /// Test the property 'AllowedFormats'
        /// </summary>
        [Fact]
        public void AllowedFormatsTest()
        {
            // TODO unit test for the property 'AllowedFormats'
        }
        /// <summary>
        /// Test the property 'LimitIds'
        /// </summary>
        [Fact]
        public void LimitIdsTest()
        {
            // TODO unit test for the property 'LimitIds'
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
        /// Test the property 'Description'
        /// </summary>
        [Fact]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'AddProperties'
        /// </summary>
        [Fact]
        public void AddPropertiesTest()
        {
            // TODO unit test for the property 'AddProperties'
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

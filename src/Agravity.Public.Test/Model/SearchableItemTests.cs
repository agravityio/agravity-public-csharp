/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2023. All Rights Reserved
 *
 * The version of the OpenAPI document: 5.2.2
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
    ///  Class for testing SearchableItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SearchableItemTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SearchableItem
        //private SearchableItem instance;

        public SearchableItemTests()
        {
            // TODO uncomment below to create an instance of SearchableItem
            //instance = new SearchableItem();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SearchableItem
        /// </summary>
        [Fact]
        public void SearchableItemInstanceTest()
        {
            // TODO uncomment below to test "IsType" SearchableItem
            //Assert.IsType<SearchableItem>(instance);
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
        /// Test the property 'IsKey'
        /// </summary>
        [Fact]
        public void IsKeyTest()
        {
            // TODO unit test for the property 'IsKey'
        }
        /// <summary>
        /// Test the property 'Filterable'
        /// </summary>
        [Fact]
        public void FilterableTest()
        {
            // TODO unit test for the property 'Filterable'
        }
        /// <summary>
        /// Test the property 'Hidden'
        /// </summary>
        [Fact]
        public void HiddenTest()
        {
            // TODO unit test for the property 'Hidden'
        }
        /// <summary>
        /// Test the property 'Searchable'
        /// </summary>
        [Fact]
        public void SearchableTest()
        {
            // TODO unit test for the property 'Searchable'
        }
        /// <summary>
        /// Test the property 'Facetable'
        /// </summary>
        [Fact]
        public void FacetableTest()
        {
            // TODO unit test for the property 'Facetable'
        }
        /// <summary>
        /// Test the property 'Sortable'
        /// </summary>
        [Fact]
        public void SortableTest()
        {
            // TODO unit test for the property 'Sortable'
        }
        /// <summary>
        /// Test the property 'IsCollection'
        /// </summary>
        [Fact]
        public void IsCollectionTest()
        {
            // TODO unit test for the property 'IsCollection'
        }
        /// <summary>
        /// Test the property 'Searchtype'
        /// </summary>
        [Fact]
        public void SearchtypeTest()
        {
            // TODO unit test for the property 'Searchtype'
        }
        /// <summary>
        /// Test the property 'Fields'
        /// </summary>
        [Fact]
        public void FieldsTest()
        {
            // TODO unit test for the property 'Fields'
        }

    }

}

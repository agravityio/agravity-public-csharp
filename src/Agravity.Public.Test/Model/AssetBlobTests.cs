/*
 * Agravity OpenAPI Documentation - Public Functions
 *
 * <h1>Agravity API Reference</h1>This is the public API description of Agravity GmbH.<br/><h2>Resources</h2><ul> <li>Collection type management</li> <li>Collections management</li> <li>Assets management</li> <li>Assets operations</li> <li>Assets publishing</li> <li>Collection Sharing (consume share)</li> <li>Secure Upload (validate + upload file)</li> <li>Download ZIP</li> <li>Search</li> <li>General management</li></ul><h2> Operations</h2>Agravity API performs the following operations:<ul> <li>List / get single collection types</li> <li>List / get single collections</li> <li>List / get single  assets</li> <li>Operations on assets like: blobs, rotate, resize, similar, collections, customfields, download</li> <li>List / get single published asset</li> <li>Search for assets or collections</li> <li>Get version of deployment</li></ul><br/><b>API key is needed to access these endpoints.</b><br/><br/>Copyright © Agravity GmbH 2024. All Rights Reserved
 *
 * The version of the OpenAPI document: 6.1.2
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
    ///  Class for testing AssetBlob
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AssetBlobTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AssetBlob
        //private AssetBlob instance;

        public AssetBlobTests()
        {
            // TODO uncomment below to create an instance of AssetBlob
            //instance = new AssetBlob();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AssetBlob
        /// </summary>
        [Fact]
        public void AssetBlobInstanceTest()
        {
            // TODO uncomment below to test "IsType" AssetBlob
            //Assert.IsType<AssetBlob>(instance);
        }


        /// <summary>
        /// Test the property 'BlobType'
        /// </summary>
        [Fact]
        public void BlobTypeTest()
        {
            // TODO unit test for the property 'BlobType'
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
        /// Test the property 'Container'
        /// </summary>
        [Fact]
        public void ContainerTest()
        {
            // TODO unit test for the property 'Container'
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
        /// Test the property 'Extension'
        /// </summary>
        [Fact]
        public void ExtensionTest()
        {
            // TODO unit test for the property 'Extension'
        }
        /// <summary>
        /// Test the property 'ContentType'
        /// </summary>
        [Fact]
        public void ContentTypeTest()
        {
            // TODO unit test for the property 'ContentType'
        }
        /// <summary>
        /// Test the property 'Md5'
        /// </summary>
        [Fact]
        public void Md5Test()
        {
            // TODO unit test for the property 'Md5'
        }
        /// <summary>
        /// Test the property 'Techdata'
        /// </summary>
        [Fact]
        public void TechdataTest()
        {
            // TODO unit test for the property 'Techdata'
        }
        /// <summary>
        /// Test the property 'AddData'
        /// </summary>
        [Fact]
        public void AddDataTest()
        {
            // TODO unit test for the property 'AddData'
        }
        /// <summary>
        /// Test the property 'Width'
        /// </summary>
        [Fact]
        public void WidthTest()
        {
            // TODO unit test for the property 'Width'
        }
        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Fact]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }
        /// <summary>
        /// Test the property 'Maxwidthheight'
        /// </summary>
        [Fact]
        public void MaxwidthheightTest()
        {
            // TODO unit test for the property 'Maxwidthheight'
        }
        /// <summary>
        /// Test the property 'Quality'
        /// </summary>
        [Fact]
        public void QualityTest()
        {
            // TODO unit test for the property 'Quality'
        }
        /// <summary>
        /// Test the property 'Orientation'
        /// </summary>
        [Fact]
        public void OrientationTest()
        {
            // TODO unit test for the property 'Orientation'
        }
        /// <summary>
        /// Test the property 'Colorspace'
        /// </summary>
        [Fact]
        public void ColorspaceTest()
        {
            // TODO unit test for the property 'Colorspace'
        }
        /// <summary>
        /// Test the property 'Profile'
        /// </summary>
        [Fact]
        public void ProfileTest()
        {
            // TODO unit test for the property 'Profile'
        }
        /// <summary>
        /// Test the property 'Transparency'
        /// </summary>
        [Fact]
        public void TransparencyTest()
        {
            // TODO unit test for the property 'Transparency'
        }
        /// <summary>
        /// Test the property 'Mode'
        /// </summary>
        [Fact]
        public void ModeTest()
        {
            // TODO unit test for the property 'Mode'
        }
        /// <summary>
        /// Test the property 'Target'
        /// </summary>
        [Fact]
        public void TargetTest()
        {
            // TODO unit test for the property 'Target'
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
        /// Test the property 'DpiX'
        /// </summary>
        [Fact]
        public void DpiXTest()
        {
            // TODO unit test for the property 'DpiX'
        }
        /// <summary>
        /// Test the property 'DpiY'
        /// </summary>
        [Fact]
        public void DpiYTest()
        {
            // TODO unit test for the property 'DpiY'
        }
        /// <summary>
        /// Test the property 'Perhash'
        /// </summary>
        [Fact]
        public void PerhashTest()
        {
            // TODO unit test for the property 'Perhash'
        }
        /// <summary>
        /// Test the property 'Dominantcolor'
        /// </summary>
        [Fact]
        public void DominantcolorTest()
        {
            // TODO unit test for the property 'Dominantcolor'
        }
        /// <summary>
        /// Test the property 'Depth'
        /// </summary>
        [Fact]
        public void DepthTest()
        {
            // TODO unit test for the property 'Depth'
        }
        /// <summary>
        /// Test the property 'Animated'
        /// </summary>
        [Fact]
        public void AnimatedTest()
        {
            // TODO unit test for the property 'Animated'
        }
        /// <summary>
        /// Test the property 'Duration'
        /// </summary>
        [Fact]
        public void DurationTest()
        {
            // TODO unit test for the property 'Duration'
        }
        /// <summary>
        /// Test the property 'Videocodec'
        /// </summary>
        [Fact]
        public void VideocodecTest()
        {
            // TODO unit test for the property 'Videocodec'
        }
        /// <summary>
        /// Test the property 'Videobitrate'
        /// </summary>
        [Fact]
        public void VideobitrateTest()
        {
            // TODO unit test for the property 'Videobitrate'
        }
        /// <summary>
        /// Test the property 'Fps'
        /// </summary>
        [Fact]
        public void FpsTest()
        {
            // TODO unit test for the property 'Fps'
        }
        /// <summary>
        /// Test the property 'Colormode'
        /// </summary>
        [Fact]
        public void ColormodeTest()
        {
            // TODO unit test for the property 'Colormode'
        }
        /// <summary>
        /// Test the property 'Audiocodec'
        /// </summary>
        [Fact]
        public void AudiocodecTest()
        {
            // TODO unit test for the property 'Audiocodec'
        }
        /// <summary>
        /// Test the property 'Audiosamplerate'
        /// </summary>
        [Fact]
        public void AudiosamplerateTest()
        {
            // TODO unit test for the property 'Audiosamplerate'
        }
        /// <summary>
        /// Test the property 'Audiochanneloutput'
        /// </summary>
        [Fact]
        public void AudiochanneloutputTest()
        {
            // TODO unit test for the property 'Audiochanneloutput'
        }
        /// <summary>
        /// Test the property 'Audiobitrate'
        /// </summary>
        [Fact]
        public void AudiobitrateTest()
        {
            // TODO unit test for the property 'Audiobitrate'
        }
        /// <summary>
        /// Test the property 'Author'
        /// </summary>
        [Fact]
        public void AuthorTest()
        {
            // TODO unit test for the property 'Author'
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'Wordcount'
        /// </summary>
        [Fact]
        public void WordcountTest()
        {
            // TODO unit test for the property 'Wordcount'
        }
        /// <summary>
        /// Test the property 'Pages'
        /// </summary>
        [Fact]
        public void PagesTest()
        {
            // TODO unit test for the property 'Pages'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'EncodingName'
        /// </summary>
        [Fact]
        public void EncodingNameTest()
        {
            // TODO unit test for the property 'EncodingName'
        }
        /// <summary>
        /// Test the property 'EncodingCode'
        /// </summary>
        [Fact]
        public void EncodingCodeTest()
        {
            // TODO unit test for the property 'EncodingCode'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'SizeReadable'
        /// </summary>
        [Fact]
        public void SizeReadableTest()
        {
            // TODO unit test for the property 'SizeReadable'
        }
        /// <summary>
        /// Test the property 'Downloadable'
        /// </summary>
        [Fact]
        public void DownloadableTest()
        {
            // TODO unit test for the property 'Downloadable'
        }
        /// <summary>
        /// Test the property 'Expires'
        /// </summary>
        [Fact]
        public void ExpiresTest()
        {
            // TODO unit test for the property 'Expires'
        }

    }

}

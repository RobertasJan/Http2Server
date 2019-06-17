using Http2Server.Common.Classes;
using Http2Server.Common.Interfaces;
using System;
using Xunit;

namespace Http2ServerTests
{
    public class FileContentManagerTests
    {
        [Fact]
        public void Get_Implemented_Extension_ContentType()
        {
            IFileContentTypeManager manager = new FileContentTypeManager();

            var result = manager.GetContentTypeFromExtension(".png");

            Assert.Equal("image/png", result);
        }
        [Fact]
        public void Get_Implemented_Extension_ContentType_File()
        {
            IFileContentTypeManager manager = new FileContentTypeManager();

            var result = manager.GetContentTypeFromFileName("test.png");

            Assert.Equal("image/png", result);
        }

        [Fact]
        public void Get_NotImplemented_Extension_ContentType()
        {
            IFileContentTypeManager manager = new FileContentTypeManager();

            Assert.Throws<NotImplementedException>(() => manager.GetContentTypeFromExtension(".xml"));
        }

        [Fact]
        public void Get_NotImplemented_Extension_ContentType_File()
        {
            IFileContentTypeManager manager = new FileContentTypeManager();

            Assert.Throws<NotImplementedException>(() => manager.GetContentTypeFromFileName("test.xml"));
        }

        [Fact]
        public void Get_EmptyFileName_Extension_ContentType()
        {
            IFileContentTypeManager manager = new FileContentTypeManager();

            Assert.Throws<ArgumentException>(() => manager.GetContentTypeFromFileName(null));
        }

        [Fact]
        public void Get_NotImplemented_Extension_ContentType_Empty()
        {
            IFileContentTypeManager manager = new FileContentTypeManager();

            Assert.Throws<NotImplementedException>(() => manager.GetContentTypeFromExtension(""));
        }


    }
}

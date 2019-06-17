using Http2Server.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Http2Server.Common.Classes
{
    public class FileContentTypeManager : IFileContentTypeManager
    {
        /// <summary>
        /// TKey = File name extension i.e. "xml, jpg, txt"
        /// TValue = html content type from extension
        /// </summary>
        private Dictionary<string, string> _contentTypes = new Dictionary<string, string>() {
            {".txt", "text/plain" },
            {".png", "image/png" }
        };

        public string GetContentTypeFromExtension(string extension)
        {
            string result = _contentTypes.GetValueOrDefault(extension);
            if (String.IsNullOrEmpty(result))
                throw new NotImplementedException("Not recognized/implemented file extension");
            return result;
        }

        public string GetContentTypeFromFileName(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName))
                throw new ArgumentException("Empty or null fileName argument");
            return GetContentTypeFromExtension(Path.GetExtension(fileName));
        }
    }
}

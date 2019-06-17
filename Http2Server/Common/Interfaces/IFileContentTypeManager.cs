using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Http2Server.Common.Interfaces
{
    public interface IFileContentTypeManager
    {
        string GetContentTypeFromExtension(string extension);
        string GetContentTypeFromFileName(string fileName);
    }
}

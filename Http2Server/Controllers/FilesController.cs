using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Http2Server.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Http2Server.Controllers
{
    //Otherwise would have used RegisterRoutes() to route, but for simplicity I used this
    [Route("api/[controller]")]
    [Route("")]
    [ApiController]
    public class FilesController : ControllerBase
    {

        private IFileContentTypeManager _fileManager;
        private string contentRootPath = System.IO.Directory.GetCurrentDirectory() + @"\MyFiles\";

        public FilesController(IFileContentTypeManager fileManager)
        {
            _fileManager = fileManager;
        }

        // GET api/files
        [HttpGet]
        public string Get()
        {
            return "Use localhost:xxxxx/test.png or localhost:xxxxx/api/files/test.txt to test api.";
        }

        // GET api/files/5
        [HttpGet("{fileName}")]
        public async Task<IActionResult> Get(string fileName)
        {
            if (!System.IO.File.Exists(contentRootPath + fileName))
                return NotFound();
            return PhysicalFile(contentRootPath + fileName, _fileManager.GetContentTypeFromFileName(fileName), fileName);
        }
    }
}

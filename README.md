# Http2Server
Http2Server example with file download api.

Implementation is in Http2Server.

Tests are in Http2ServerTests.

API test files in Http2Server/MyFiles.
API currently supports only .png and .txt files.

Use https://localhost:44301/test.txt to test FileController method GET

File extensions supportability is defined in Http2Server/Common/Classes/FileContentTypeManager.cs

Http2 defined in program.cs:                             
listenOptions.Protocols = HttpProtocols.Http2;

PROJECT USES .NET CORE 3 Preview5 SDK, which is not automatically available in Visual Studio.

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HttpNetworkReplayStreaming.h")]
public enum EHttpReplayResult {
	Success=0,
	FailedJsonParse=1,
	DataUnavailable=2,
	InvalidHttpResponse=3,
	CompressionFailed=4,
	DecompressionFailed=5,
	InvalidPayload=6,
	Unknown=7,
}

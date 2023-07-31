#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OodleNetworkFaultHandler.h")]
///<summary>Oodle net error types, for NetConnection fault handling</summary>
public enum EOodleNetResult {
	Unknown=0,
	Success=1,
	OodleDecodeFailed=2,
	OodleSerializePayloadFail=3,
	OodleBadDecompressedLength=4,
	OodleNoDictionary=5,
}

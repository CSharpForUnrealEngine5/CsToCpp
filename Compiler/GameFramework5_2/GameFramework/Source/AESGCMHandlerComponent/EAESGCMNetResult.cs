#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AESGCMFaultHandler.h")]
///<summary>AESGCM net error types, for NetConnection fault handling</summary>
public enum EAESGCMNetResult {
	Unknown=0,
	Success=1,
	AESMissingIV=2,
	AESMissingAuthTag=3,
	AESMissingPayload=4,
	AESDecryptionFailed=5,
	AESZeroLastByte=6,
}

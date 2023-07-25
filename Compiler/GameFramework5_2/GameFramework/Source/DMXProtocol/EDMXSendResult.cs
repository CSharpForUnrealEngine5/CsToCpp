#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXProtocolTypes.h")]
///<summary>Result when sending a DMX packet</summary>
public enum EDMXSendResult {
	Success=0,
	ErrorGetUniverse=1,
	ErrorSetBuffer=2,
	ErrorSizeBuffer=3,
	ErrorEnqueuePackage=4,
	ErrorNoSenderInterface=5,
}

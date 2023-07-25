#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request to set a property on a preset</summary>
public partial struct FRCPresetSetPropertyRequest {
// RCPresetSetPropertyRequest
	public ERCModifyOperation Operation;
	public bool GenerateTransaction;
	public bool ResetToDefault;
}

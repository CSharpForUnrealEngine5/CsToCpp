#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to set a property on a preset</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FRCPresetSetPropertyRequest {
	public ERCModifyOperation Operation;
	public bool GenerateTransaction;
	public bool ResetToDefault;
}

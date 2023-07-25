#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlinePIESettings.h")]
///<summary>Stores PIE login credentials</summary>
public partial struct FPIELoginSettingsInternal {
// PIELoginSettingsInternal
	public string Id;
	public string Token;
	public string Type;
	public TArray<byte> TokenBytes;
}

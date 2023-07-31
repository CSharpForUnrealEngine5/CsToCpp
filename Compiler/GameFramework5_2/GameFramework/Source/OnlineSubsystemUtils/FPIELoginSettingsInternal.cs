#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores PIE login credentials</summary>
[CppInclude("OnlinePIESettings.h")]
public partial struct FPIELoginSettingsInternal {
	public string Id;
	public string Token;
	public string Type;
	public TArray<byte> TokenBytes;
}

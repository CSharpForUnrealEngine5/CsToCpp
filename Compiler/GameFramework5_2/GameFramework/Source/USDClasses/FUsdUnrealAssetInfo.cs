#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Metadata added to a prim to indicate it was exported from a particular Unreal asset</summary>
[CppInclude("USDUnrealAssetInfo.h")]
public partial struct FUsdUnrealAssetInfo {
	public string Name;
	public string Identifier;
	public string Version;
	public string UnrealContentPath;
	public string UnrealAssetType;
	public string UnrealExportTime;
	public string UnrealEngineVersion;
}

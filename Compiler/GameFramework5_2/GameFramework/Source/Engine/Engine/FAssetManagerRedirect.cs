#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple structure for redirecting an old asset name/path to a new one</summary>
[CppInclude("Engine/AssetManagerSettings.h")]
public partial struct FAssetManagerRedirect {
	public string Old;
	public string New;
}

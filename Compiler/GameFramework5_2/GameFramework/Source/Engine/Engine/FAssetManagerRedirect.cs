namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple structure for redirecting an old asset name/path to a new one</summary>
[CppInclude("Engine/AssetManagerSettings.h")]
public partial struct FAssetManagerRedirect {
	public string Old;
	public string New;
}

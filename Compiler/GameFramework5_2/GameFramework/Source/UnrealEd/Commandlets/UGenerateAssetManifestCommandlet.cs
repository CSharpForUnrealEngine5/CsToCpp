namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Commandlet for generating a filtered list of assets from the asset registry (intended use is for replacing assets with cooked version)</summary>
[CppInclude("Commandlets/GenerateAssetManifestCommandlet.h")]
public partial class UGenerateAssetManifestCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
}

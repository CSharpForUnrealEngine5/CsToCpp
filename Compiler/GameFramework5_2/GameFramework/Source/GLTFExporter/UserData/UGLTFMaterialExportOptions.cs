namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>glTF-specific user data that can be added to material assets to override export options</summary>
[CppInclude("UserData/GLTFMaterialUserData.h")]
public partial class UGLTFMaterialExportOptions : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>If assigned, export will use the proxy instead of the original material.</summary>
	public UMaterialInterface Proxy;
	///<summary>Default bake settings for this material in general.</summary>
	public FGLTFOverrideMaterialBakeSettings Default;
	///<summary>Input-specific bake settings that override the defaults above.</summary>
	public TMap<EGLTFMaterialPropertyGroup,FGLTFOverrideMaterialBakeSettings> Inputs;
}

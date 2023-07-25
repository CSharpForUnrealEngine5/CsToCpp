#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UserData/GLTFMaterialUserData.h")]
///<summary>glTF-specific user data that can be added to material assets to override export options</summary>
public partial class UGLTFMaterialExportOptions : UAssetUserData {
// GLTFMaterialExportOptions
	public UMaterialInterface Proxy;
	public FGLTFOverrideMaterialBakeSettings Default;
	public TMap<EGLTFMaterialPropertyGroup,FGLTFOverrideMaterialBakeSettings> Inputs;
}

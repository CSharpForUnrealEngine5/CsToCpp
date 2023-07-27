#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UserData/GLTFMaterialUserData.h")]
public partial struct FGLTFOverrideMaterialBakeSettings {
// GLTFOverrideMaterialBakeSettings
	public bool bOverrideSize;
	public EGLTFMaterialBakeSizePOT Size;
	public bool bOverrideFilter;
	public TextureFilter Filter;
	public bool bOverrideTiling;
	public TextureAddress Tiling;
}

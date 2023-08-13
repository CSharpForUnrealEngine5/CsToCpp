namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UserData/GLTFMaterialUserData.h")]
public partial struct FGLTFOverrideMaterialBakeSettings {
	public bool bOverrideSize;
	public EGLTFMaterialBakeSizePOT Size;
	public bool bOverrideFilter;
	public TextureFilter Filter;
	public bool bOverrideTiling;
	public TextureAddress Tiling;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Options/GLTFProxyOptions.h")]
public partial class UGLTFProxyOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, a material input may be baked out to a texture (using a simple quad). Baking is only used for non-trivial material inputs (i.e. not simple texture or constant expressions).</summary>
	public bool bBakeMaterialInputs;
	///<summary>Default size of the baked out texture (containing the material input). Can be overridden by material- and input-specific bake settings, see GLTFMaterialExportOptions.</summary>
	public EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize;
	///<summary>Default filtering mode used when sampling the baked out texture. Can be overridden by material- and input-specific bake settings, see GLTFMaterialExportOptions.</summary>
	public TextureFilter DefaultMaterialBakeFilter;
	///<summary>Default addressing mode used when sampling the baked out texture. Can be overridden by material- and input-specific bake settings, see GLTFMaterialExportOptions.</summary>
	public TextureAddress DefaultMaterialBakeTiling;
	///<summary>Input-specific default bake settings that override the general defaults above.</summary>
	public TMap<EGLTFMaterialPropertyGroup,FGLTFOverrideMaterialBakeSettings> DefaultInputBakeSettings;
	///<summary>ResetToDefault</summary>
	public void ResetToDefault() {}
}

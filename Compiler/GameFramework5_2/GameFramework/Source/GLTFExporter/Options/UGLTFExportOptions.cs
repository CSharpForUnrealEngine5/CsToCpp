#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Options/GLTFExportOptions.h")]
public partial class UGLTFExportOptions : UObject {
	///<summary>Scale factor used for exporting all assets (0.01 by default) for conversion from centimeters (Unreal default) to meters (glTF).</summary>
	public float ExportUniformScale;
	///<summary>If enabled, the preview mesh for a standalone animation or material asset will also be exported.</summary>
	public bool bExportPreviewMesh;
	///<summary>If enabled, floating-point-based JSON properties that are nearly equal to their default value will not be exported and thus regarded as exactly default, reducing JSON size.</summary>
	public bool bSkipNearDefaultValues;
	///<summary>If enabled, materials that have a proxy defined in their user data, will be exported using that proxy instead. This setting won&#39;t affect proxy materials exported or referenced directly.</summary>
	public bool bExportProxyMaterials;
	///<summary>If enabled, materials with shading model unlit will be properly exported. Uses extension KHR_materials_unlit.</summary>
	public bool bExportUnlitMaterials;
	///<summary>If enabled, materials with shading model clear coat will be properly exported. Uses extension KHR_materials_clearcoat, which is not supported by all glTF viewers.</summary>
	public bool bExportClearCoatMaterials;
	///<summary>Bake mode determining if and how a material input is baked out to a texture. Baking is only used for non-trivial material inputs (i.e. not simple texture or constant expressions).</summary>
	public EGLTFMaterialBakeMode BakeMaterialInputs;
	///<summary>Default size of the baked out texture (containing the material input). Can be overridden by material- and input-specific bake settings, see GLTFMaterialExportOptions.</summary>
	public EGLTFMaterialBakeSizePOT DefaultMaterialBakeSize;
	///<summary>Default filtering mode used when sampling the baked out texture. Can be overridden by material- and input-specific bake settings, see GLTFMaterialExportOptions.</summary>
	public TextureFilter DefaultMaterialBakeFilter;
	///<summary>Default addressing mode used when sampling the baked out texture. Can be overridden by material- and input-specific bake settings, see GLTFMaterialExportOptions.</summary>
	public TextureAddress DefaultMaterialBakeTiling;
	///<summary>Input-specific default bake settings that override the general defaults above.</summary>
	public TMap<EGLTFMaterialPropertyGroup,FGLTFOverrideMaterialBakeSettings> DefaultInputBakeSettings;
	///<summary>Default LOD level used for exporting a mesh. Can be overridden by component or asset settings (e.g. minimum or forced LOD level).</summary>
	public int DefaultLevelOfDetail;
	///<summary>If enabled, export vertex color. Not recommended due to vertex colors always being used as a base color multiplier in glTF, regardless of material. Often producing undesirable results.</summary>
	public bool bExportVertexColors;
	///<summary>If enabled, export vertex bone weights and indices in skeletal meshes. Necessary for animation sequences.</summary>
	public bool bExportVertexSkinWeights;
	///<summary>If enabled, use quantization for vertex tangents and normals, reducing size. Requires extension KHR_mesh_quantization, which may result in the mesh not loading in some glTF viewers.</summary>
	public bool bUseMeshQuantization;
	///<summary>If enabled, export level sequences. Only transform tracks are currently supported. The level sequence will be played at the assigned display rate.</summary>
	public bool bExportLevelSequences;
	///<summary>If enabled, export single animation asset used by a skeletal mesh component. Export of vertex skin weights must be enabled.</summary>
	public bool bExportAnimationSequences;
	///<summary>Desired image format used for exported textures.</summary>
	public EGLTFTextureImageFormat TextureImageFormat;
	///<summary>Level of compression used for textures exported with lossy image formats, 0 (default) or value between 1 (worst quality, best compression) and 100 (best quality, worst compression).</summary>
	public int TextureImageQuality;
	///<summary>If enabled, export UV tiling and un-mirroring settings in a texture coordinate expression node for simple material input expressions. Uses extension KHR_texture_transform.</summary>
	public bool bExportTextureTransforms;
	///<summary>If enabled, exported normalmaps will be adjusted from Unreal to glTF convention (i.e. the green channel is flipped).</summary>
	public bool bAdjustNormalmaps;
	///<summary>If enabled, export actors and components that are flagged as hidden in-game.</summary>
	public bool bExportHiddenInGame;
	///<summary>If enabled, export directional, point, and spot light components. Uses extension KHR_lights_punctual.</summary>
	public bool bExportLights;
	///<summary>If enabled, export camera components.</summary>
	public bool bExportCameras;
	///<summary>Mode determining if and how to export material variants that change the materials property on a static or skeletal mesh component.</summary>
	public EGLTFMaterialVariantMode ExportMaterialVariants;
	///<summary>ResetToDefault</summary>
	public  void ResetToDefault() {}
}

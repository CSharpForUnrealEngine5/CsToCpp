namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Material is an asset which can be applied to a mesh to control the visual look of the scene.</summary>
[CppInclude("Materials/Material.h")]
public partial class UMaterial : UMaterialInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Physical material to use for this graphics material. Used for sounds, effects etc.</summary>
	public UPhysicalMaterial PhysMaterial;
	///<summary>Physical material mask to use for this graphics material. Used for sounds, effects etc.</summary>
	public UPhysicalMaterialMask PhysMaterialMask;
	///<summary>Physical material mask map to use for this graphics material. Used for sounds, effects etc.</summary>
	public UPhysicalMaterial PhysicalMaterialMap;
	///<summary>RenderTracePhysicalMaterialOutputs</summary>
	public TArray<UPhysicalMaterial> RenderTracePhysicalMaterialOutputs;
	///<summary>The domain that the material&#39;s attributes will be evaluated in.</summary>
	public EMaterialDomain MaterialDomain;
	///<summary>Determines how the material&#39;s color is blended with background colors.</summary>
	public EBlendMode BlendMode;
	///<summary>DecalBlendMode</summary>
	public EDecalBlendMode DecalBlendMode;
	///<summary>Defines how the material reacts on DBuffer decals (Affects look, performance and texture/sample usage).</summary>
	public EMaterialDecalResponse MaterialDecalResponse;
	///<summary>An override material which will be used instead of this one when rendering with Nanite.</summary>
	public FMaterialOverrideNanite NaniteOverrideMaterial;
	///<summary>DisplacementScaling</summary>
	public FDisplacementScaling DisplacementScaling;
	///<summary>Determines how inputs are combined to create the material&#39;s final color.</summary>
	public EMaterialShadingModel ShadingModel;
	///<summary>Whether the material should cast shadows as masked even though it has a translucent blend mode.</summary>
	public bool bCastDynamicShadowAsMasked;
	///<summary>ShadingModels</summary>
	public FMaterialShadingModelField ShadingModels;
	///<summary>These are the shading models present in this material. Note that all these shading models might not be used in all feature levels and quality levels.</summary>
	public string UsedShadingModels;
	///<summary>If BlendMode is BLEND_Masked, the surface is not rendered where OpacityMask &lt; OpacityMaskClipValue.</summary>
	public float OpacityMaskClipValue;
	///<summary>Deprecated. Use TranslucencyPass instead.</summary>
	public bool bEnableSeparateTranslucency_DEPRECATED;
	///<summary>Indicates that the material should be rendered using responsive anti-aliasing. Improves sharpness of small moving particles such as sparks.</summary>
	public bool bEnableResponsiveAA;
	///<summary>SSR on translucency</summary>
	public bool bScreenSpaceReflections;
	///<summary>Contact shadows on translucency</summary>
	public bool bContactShadows;
	///<summary>Indicates that the material should be rendered without backface culling and the normal should be flipped for backfaces.</summary>
	public bool TwoSided;
	///<summary>Indicates that the material should be rendered as a thin surface (i.e., without inner volume). Only used by Substrate materials. Enabling ThinSurface will disable subsurface profiles.</summary>
	public bool bIsThinSurface;
	///<summary>Whether meshes rendered with the material should support dithered LOD transitions.</summary>
	public bool DitheredLODTransition;
	///<summary>Dither opacity mask. When combined with Temporal AA this can be used as a form of limited translucency which supports all lighting features.</summary>
	public bool DitherOpacityMask;
	///<summary>Whether the material should allow outputting negative emissive color values.  Only allowed on unlit materials.</summary>
	public bool bAllowNegativeEmissiveColor;
	///<summary>Specifies the separate pass in which to render translucency.</summary>
	public EMaterialTranslucencyPass TranslucencyPass;
	///<summary>Sets the lighting mode that will be used on this material if it is translucent.</summary>
	public ETranslucencyLightingMode TranslucencyLightingMode;
	///<summary>Indicates that the translucent material should not be affected by bloom or DOF. (Note: Depth testing is not available)</summary>
	public bool bEnableMobileSeparateTranslucency;
	///<summary>Number of customized UV inputs to display.  Unconnected customized UV inputs will just pass through the vertex UVs.</summary>
	public int NumCustomizedUVs;
	///<summary>Useful for artificially increasing the influence of the normal on the lighting result for translucency.</summary>
	public float TranslucencyDirectionalLightingIntensity;
	///<summary>Scale used to make translucent shadows more or less opaque than the material&#39;s actual opacity.</summary>
	public float TranslucentShadowDensityScale;
	///<summary>Scale used to make translucent self-shadowing more or less opaque than the material&#39;s shadow on other objects.</summary>
	public float TranslucentSelfShadowDensityScale;
	///<summary>Used to make a second self shadow gradient, to add interesting shading in the shadow of the first.</summary>
	public float TranslucentSelfShadowSecondDensityScale;
	///<summary>Controls the strength of the second self shadow gradient.</summary>
	public float TranslucentSelfShadowSecondOpacity;
	///<summary>Controls how diffuse the material&#39;s backscattering is when using the MSM_Subsurface shading model.</summary>
	public float TranslucentBackscatteringExponent;
	///<summary>Colored extinction factor used to approximate multiple scattering in dense volumes.</summary>
	public FLinearColor TranslucentMultipleScatteringExtinction;
	///<summary>Local space distance to bias the translucent shadow.  Positive values move the shadow away from the light.</summary>
	public float TranslucentShadowStartOffset;
	///<summary>Whether to draw on top of opaque pixels even if behind them. This only has meaning for translucency.</summary>
	public bool bDisableDepthTest;
	///<summary>Whether the transluency pass should write its alpha, and only the alpha, into the framebuffer</summary>
	public bool bWriteOnlyAlpha;
	///<summary>Whether to generate spherical normals for particles that use this material.</summary>
	public bool bGenerateSphericalParticleNormals;
	///<summary>Whether the material takes a tangent space normal or a world space normal as input.</summary>
	public bool bTangentSpaceNormal;
	///<summary>If enabled, the material&#39;s emissive colour is injected into the LightPropagationVolume</summary>
	public bool bUseEmissiveForDynamicAreaLighting;
	///<summary>This is a special usage flag that allows a material to be assignable to any primitive type.</summary>
	public bool bUsedAsSpecialEngineMaterial;
	///<summary>Indicates that the material and its instances can be used with skeletal meshes.</summary>
	public bool bUsedWithSkeletalMesh;
	///<summary>Indicates that the material and its instances can be used with editor compositing</summary>
	public bool bUsedWithEditorCompositing;
	///<summary>Indicates that the material and its instances can be used with particle sprites</summary>
	public bool bUsedWithParticleSprites;
	///<summary>Indicates that the material and its instances can be used with beam trails</summary>
	public bool bUsedWithBeamTrails;
	///<summary>Indicates that the material and its instances can be used with mesh particles</summary>
	public bool bUsedWithMeshParticles;
	///<summary>Indicates that the material and its instances can be used with Niagara sprites (meshes and ribbons, respectively)</summary>
	public bool bUsedWithNiagaraSprites;
	///<summary>bUsedWithNiagaraRibbons</summary>
	public bool bUsedWithNiagaraRibbons;
	///<summary>bUsedWithNiagaraMeshParticles</summary>
	public bool bUsedWithNiagaraMeshParticles;
	///<summary>bUsedWithGeometryCache</summary>
	public bool bUsedWithGeometryCache;
	///<summary>Indicates that the material and its instances can be used with static lighting</summary>
	public bool bUsedWithStaticLighting;
	///<summary>Indicates that the material and its instances can be used with morph targets</summary>
	public bool bUsedWithMorphTargets;
	///<summary>Indicates that the material and its instances can be used with spline meshes</summary>
	public bool bUsedWithSplineMeshes;
	///<summary>Indicates that the material and its instances can be used with instanced static meshes</summary>
	public bool bUsedWithInstancedStaticMeshes;
	///<summary>Indicates that the material and its instances can be use with geometry collections</summary>
	public bool bUsedWithGeometryCollections;
	///<summary>Indicates that the material and its instances can be used with distortion</summary>
	public bool bUsesDistortion;
	///<summary>Indicates that the material do not use the material physically based refraction (e.g. IOR from reflectivity F0), but overrides it for artistic purposes.</summary>
	public bool bRootNodeOverridesDefaultDistortion;
	///<summary>Indicates that the material and its instances can be used with clothing</summary>
	public bool bUsedWithClothing;
	///<summary>Indicates that the material and its instances can be use with water</summary>
	public bool bUsedWithWater;
	///<summary>Indicates that the material and its instances can be use with hair strands</summary>
	public bool bUsedWithHairStrands;
	///<summary>Indicates that the material and its instances can be use with LiDAR Point Clouds</summary>
	public bool bUsedWithLidarPointCloud;
	///<summary>Indicates that the material and its instances can be used with Virtual Heightfield Mesh.</summary>
	public bool bUsedWithVirtualHeightfieldMesh;
	///<summary>Indicates that the material and its instances can be used with Nanite meshes.</summary>
	public bool bUsedWithNanite;
	///<summary>Indicates that the material and its instances with volumetric cloud. Without that flag, it can only be used on volumetric fog.</summary>
	public bool bUsedWithVolumetricCloud;
	///<summary>Indicates that the material and its instances with heterogeneous volumes. Without that flag, it can only be used on volumetric fog.</summary>
	public bool bUsedWithHeterogeneousVolumes;
	///<summary>Indicates that the material and its instances can be used with Slate UI and UMG</summary>
	public bool bUsedWithUI_DEPRECATED;
	///<summary>Whether to automatically set usage flags based on what the material is applied to in the editor.</summary>
	public bool bAutomaticallySetUsageInEditor;
	///<summary>Forces the material to be completely rough. Saves a number of instructions and one sampler.</summary>
	public bool bFullyRough;
	///<summary>Deprecated. Use FloatPrecisionMode instead.</summary>
	public bool bUseFullPrecision_DEPRECATED;
	///<summary>How to use full (highp) precision in the pixel shader.</summary>
	public EMaterialFloatPrecisionMode FloatPrecisionMode;
	///<summary>Use lightmap directionality and per pixel normals. If disabled, lighting from lightmaps will be flat but cheaper.</summary>
	public bool bUseLightmapDirectionality;
	///<summary>Use the high quality brdf functions on mobile to get better visual effects but adds GPU cost.</summary>
	public bool bMobileEnableHighQualityBRDF;
	///<summary>Use alpha to coverage for masked material on mobile, make sure MSAA is enabled as well.</summary>
	public bool bUseAlphaToCoverage;
	///<summary>Forward (including mobile) renderer: use preintegrated GF lut for simple IBL, but will use one more sampler.</summary>
	public bool bForwardRenderUsePreintegratedGFForSimpleIBL;
	///<summary>* Forward renderer: enables multiple parallax-corrected reflection captures that blend together.</summary>
	public bool bUseHQForwardReflections;
	///<summary>* Enables blending of sky light cubemap textures. When disabled, the secondary cubemap is only visible when the blend factor is 1.</summary>
	public bool bForwardBlendsSkyLightCubemaps;
	///<summary>Enables planar reflection when using the forward renderer or mobile. Enabling this setting reduces the number of samplers available to the material as one more sampler will be used for the planar reflection.</summary>
	public bool bUsePlanarForwardReflections;
	///<summary>Reduce roughness based on screen space normal changes.</summary>
	public bool bNormalCurvatureToRoughness;
	///<summary>Allows a translucent material to be used with custom depth writing by compiling additional shaders.</summary>
	public bool AllowTranslucentCustomDepthWrites;
	///<summary>Allows a translucent material to be used with Front Layer Translucency by compiling additional shaders. Useful for controlling what should be included in Front Layer Translucency.</summary>
	public bool bAllowFrontLayerTranslucency;
	///<summary>Enables a wireframe view of the mesh the material is applied to.</summary>
	public bool Wireframe;
	///<summary>Select what shading rate to apply, on platforms that support variable rate shading.</summary>
	public EMaterialShadingRate ShadingRate;
	///<summary>EditorX</summary>
	public int EditorX;
	///<summary>EditorY</summary>
	public int EditorY;
	///<summary>EditorPitch</summary>
	public int EditorPitch;
	///<summary>EditorYaw</summary>
	public int EditorYaw;
	///<summary>true if this Material can be assumed Opaque when set to masked.</summary>
	public bool bCanMaskedBeAssumedOpaque;
	///<summary>true if Material is masked and uses custom opacity</summary>
	public bool bIsMasked_DEPRECATED;
	///<summary>true if Material is the preview material used in the material editor.</summary>
	public bool bIsPreviewMaterial;
	///<summary>true if Material is the function preview material used in the material instance editor.</summary>
	public bool bIsFunctionPreviewMaterial;
	///<summary>when true, the material attributes pin is used instead of the regular pins.</summary>
	public bool bUseMaterialAttributes;
	///<summary>bEnableExecWire</summary>
	public bool bEnableExecWire;
	///<summary>bEnableNewHLSLGenerator</summary>
	public bool bEnableNewHLSLGenerator;
	///<summary>when true, the material casts ray tracing shadows.</summary>
	public bool bCastRayTracedShadows;
	///<summary>When true, translucent materials are fogged. Defaults to true.</summary>
	public bool bUseTranslucencyVertexFog;
	///<summary>When true, translucent materials receive cloud contribution as part of the fog evaluation, per vertex or per pixel according to the other selected options. This is a rough approximation but can help in some cases. Defaults to false. Fog is applied on clouds, so Apply Fogging must be true to use this feature.</summary>
	public bool bApplyCloudFogging;
	///<summary>Unlit and Opaque materials can be used as sky material on a sky dome mesh. When IsSky is true, these meshes will not receive any contribution from the aerial perspective. Height and Volumetric fog effects will still be applied.</summary>
	public bool bIsSky;
	///<summary>When true, translucent materials have fog computed for every pixel, which costs more but fixes artifacts due to low tessellation.</summary>
	public bool bComputeFogPerPixel;
	///<summary>When true, translucent materials will output motion vectors and write to depth buffer in velocity pass.</summary>
	public bool bOutputTranslucentVelocity;
	///<summary>If true the compilation environment will be changed to remove the global COMPILE_SHADERS_FOR_DEVELOPMENT flag.</summary>
	public bool bAllowDevelopmentShaderCompile;
	///<summary>true if this is a special material used for stats by the material editor.</summary>
	public bool bIsMaterialEditorStatsMaterial;
	///<summary>Where the node is inserted in the (post processing) graph, only used if domain is PostProcess</summary>
	public EBlendableLocation BlendableLocation;
	///<summary>If this is enabled, the blendable will output alpha</summary>
	public bool BlendableOutputAlpha;
	///<summary>Selectively execute post process material only for pixels that pass the stencil test against the Custom Depth/Stencil buffer.</summary>
	public bool bEnableStencilTest;
	///<summary>StencilCompare</summary>
	public EMaterialStencilCompare StencilCompare;
	///<summary>StencilRefValue</summary>
	public byte StencilRefValue;
	///<summary>RefractionMode_DEPRECATED</summary>
	public ERefractionMode RefractionMode_DEPRECATED;
	///<summary>Controls how the Refraction input is interpreted and how the refraction offset into scene color is computed for this material.</summary>
	public ERefractionMode RefractionMethod;
	///<summary>Controls whether refraction takes into account the material surface coverage, or not.</summary>
	public ERefractionCoverageMode RefractionCoverageMode;
	///<summary>If multiple nodes with the same  type are inserted at the same point, this defined order and if they get combined, only used if domain is PostProcess</summary>
	public int BlendablePriority;
	///<summary>Allows blendability to be turned off, only used if domain is PostProcess</summary>
	public bool bIsBlendable;
	///<summary>true if we have printed a warning about material usage for a given usage flag.</summary>
	public uint UsageFlagWarnings;
	///<summary>This is the refraction depth bias, larger values offset distortion to prevent closer objects from rendering into the distorted surface at acute viewing angles but increases the disconnect between surface and where the refraction starts.</summary>
	public float RefractionDepthBias;
	///<summary>Specifies the max world position offset of the material. Use this value to resolve issues with culling and self-occlusion caused by</summary>
	public float MaxWorldPositionOffsetDisplacement;
	///<summary>Forces World Position Offset to always be evaluated for this material, even if the primitive it&#39;s applied to has disabled it</summary>
	public bool bAlwaysEvaluateWorldPositionOffset;
	///<summary>Guid that uniquely identifies this material.</summary>
	public FGuid StateId;
	///<summary>bSavedCachedExpressionData_DEPRECATED</summary>
	public bool bSavedCachedExpressionData_DEPRECATED;
	///<summary>ReferencedTextureGuids</summary>
	public TArray<FGuid> ReferencedTextureGuids;
	///<summary>EditorComments_DEPRECATED</summary>
	public TArray<UMaterialExpressionComment> EditorComments_DEPRECATED;
	///<summary>ExpressionExecBegin_DEPRECATED</summary>
	public UMaterialExpressionExecBegin ExpressionExecBegin_DEPRECATED;
	///<summary>ExpressionExecEnd_DEPRECATED</summary>
	public UMaterialExpressionExecEnd ExpressionExecEnd_DEPRECATED;
	///<summary>Expressions_DEPRECATED</summary>
	public TArray<UMaterialExpression> Expressions_DEPRECATED;
	///<summary>ParameterGroupData_DEPRECATED</summary>
	public TArray<FParameterGroupData> ParameterGroupData_DEPRECATED;
	///<summary>DiffuseColor_DEPRECATED</summary>
	public FColorMaterialInput DiffuseColor_DEPRECATED;
	///<summary>SpecularColor_DEPRECATED</summary>
	public FColorMaterialInput SpecularColor_DEPRECATED;
	///<summary>BaseColor_DEPRECATED</summary>
	public FColorMaterialInput BaseColor_DEPRECATED;
	///<summary>Metallic_DEPRECATED</summary>
	public FScalarMaterialInput Metallic_DEPRECATED;
	///<summary>Specular_DEPRECATED</summary>
	public FScalarMaterialInput Specular_DEPRECATED;
	///<summary>Roughness_DEPRECATED</summary>
	public FScalarMaterialInput Roughness_DEPRECATED;
	///<summary>Anisotropy_DEPRECATED</summary>
	public FScalarMaterialInput Anisotropy_DEPRECATED;
	///<summary>Normal_DEPRECATED</summary>
	public FVectorMaterialInput Normal_DEPRECATED;
	///<summary>Tangent_DEPRECATED</summary>
	public FVectorMaterialInput Tangent_DEPRECATED;
	///<summary>EmissiveColor_DEPRECATED</summary>
	public FColorMaterialInput EmissiveColor_DEPRECATED;
	///<summary>Opacity_DEPRECATED</summary>
	public FScalarMaterialInput Opacity_DEPRECATED;
	///<summary>OpacityMask_DEPRECATED</summary>
	public FScalarMaterialInput OpacityMask_DEPRECATED;
	///<summary>WorldPositionOffset_DEPRECATED</summary>
	public FVectorMaterialInput WorldPositionOffset_DEPRECATED;
	///<summary>SubsurfaceColor_DEPRECATED</summary>
	public FColorMaterialInput SubsurfaceColor_DEPRECATED;
	///<summary>ClearCoat_DEPRECATED</summary>
	public FScalarMaterialInput ClearCoat_DEPRECATED;
	///<summary>ClearCoatRoughness_DEPRECATED</summary>
	public FScalarMaterialInput ClearCoatRoughness_DEPRECATED;
	///<summary>AmbientOcclusion_DEPRECATED</summary>
	public FScalarMaterialInput AmbientOcclusion_DEPRECATED;
	///<summary>Refraction_DEPRECATED</summary>
	public FScalarMaterialInput Refraction_DEPRECATED;
	///<summary>CustomizedUVs_DEPRECATED</summary>
	public FVector2MaterialInput CustomizedUVs_DEPRECATED;
	///<summary>MaterialAttributes_DEPRECATED</summary>
	public FMaterialAttributesInput MaterialAttributes_DEPRECATED;
	///<summary>PixelDepthOffset_DEPRECATED</summary>
	public FScalarMaterialInput PixelDepthOffset_DEPRECATED;
	///<summary>ShadingModelFromMaterialExpression_DEPRECATED</summary>
	public FShadingModelMaterialInput ShadingModelFromMaterialExpression_DEPRECATED;
	///<summary>FrontMaterial_DEPRECATED</summary>
	public FStrataMaterialInput FrontMaterial_DEPRECATED;
}

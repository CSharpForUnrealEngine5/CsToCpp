namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Rendering settings.</summary>
[CppInclude("Engine/RendererSettings.h")]
public partial class URendererSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The shading path to use on mobile platforms. Changing this setting requires restarting the editor.</summary>
	public EMobileShadingPath MobileShadingPath;
	///<summary>Whether to enable GPUScene on mobile. GPUScene is required for mesh auto-instancing. Changing this setting requires restarting the editor.</summary>
	public bool bMobileSupportGPUScene;
	///<summary>The mobile default anti-aliasing method.</summary>
	public EMobileAntiAliasingMethod MobileAntiAliasing;
	///<summary>Project wide mobile float precision mode for shaders and materials. Changing this setting requires restarting the editor.</summary>
	public EMobileFloatPrecisionMode MobileFloatPrecisionMode;
	///<summary>Whether to support &#39;Dithered LOD Transition&#39; material option on mobile platforms. Enabling this may degrade performance as rendering will not benefit from Early-Z optimization.</summary>
	public bool bMobileAllowDitheredLODTransition;
	///<summary>Whether to support virtual textures on mobile. Requires general virtual texturing option enabled as well. Changing this setting requires restarting the editor.</summary>
	public bool bMobileVirtualTextures;
	///<summary>When running in game mode, whether to keep shaders for all quality levels in memory or only those needed for the current quality level.</summary>
	public bool bDiscardUnusedQualityLevels;
	///<summary>Select how the shaders are compressed for storage</summary>
	public EShaderCompressionFormat ShaderCompressionFormat;
	///<summary>Allows occluded meshes to be culled and not rendered.</summary>
	public bool bOcclusionCulling;
	///<summary>Screen radius at which lights are culled. Larger values can improve performance but causes lights to pop off when they affect a small area of the screen.</summary>
	public float MinScreenRadiusForLights;
	///<summary>Screen radius at which objects are culled for the early Z pass. Larger values can improve performance but very large values can degrade performance if large occluders are not rendered.</summary>
	public float MinScreenRadiusForEarlyZPass;
	///<summary>Screen radius at which objects are culled for cascaded shadow map depth passes. Larger values can improve performance but can cause artifacts as objects stop casting shadows.</summary>
	public float MinScreenRadiusForCSMdepth;
	///<summary>Displays a warning when no precomputed visibility data is available for the current camera location. This can be helpful if you are making a game that relies on precomputed visibility, e.g. a first person mobile game.</summary>
	public bool bPrecomputedVisibilityWarning;
	///<summary>When enabled textures will stream in based on what is visible on screen.</summary>
	public bool bTextureStreaming;
	///<summary>Whether to use DXT5 for normal maps, otherwise BC5 will be used, which is not supported on all hardware. Changing this setting requires restarting the editor.</summary>
	public bool bUseDXT5NormalMaps;
	///<summary>When enabled, Textures can be streamed using the virtual texture system. Changing this setting requires restarting the editor.</summary>
	public bool bVirtualTextures;
	///<summary>Set the &#39;Virtual Texture Streaming&#39; setting for imported textures based on &#39;Auto Virtual Texturing Size&#39; in the texture import settings.</summary>
	public bool bVirtualTextureEnableAutoImport;
	///<summary>When enabled, lightmaps will be streamed using the virtual texture system. Changing this setting requires restarting the editor.</summary>
	public bool bVirtualTexturedLightmaps;
	///<summary>When enabled, virtual textures will use anisotropic filtering. This adds a cost to all shaders using virtual textures. Changing this setting requires restarting the editor.</summary>
	public bool bVirtualTextureAnisotropicFiltering;
	///<summary>Relax restriction on virtual textures contributing to Opacity Mask. In some edge cases this can lead to low resolution shadow edges.</summary>
	public bool bEnableVirtualTextureOpacityMask;
	///<summary>Size in pixels for virtual texture tiles, will be rounded to next power-of-2. Changing this setting requires restarting the editor.</summary>
	public uint VirtualTextureTileSize;
	///<summary>Size in pixels for virtual texture tile borders, will be rounded to next power-of-2. Larger borders allow higher degree of anisotropic filtering, but uses more disk/cache memory. Changing this setting requires restarting the editor.</summary>
	public uint VirtualTextureTileBorderSize;
	///<summary>Lower factor will increase virtual texture feedback resolution which increases CPU/GPU overhead, but may decrease streaming latency, especially if materials use many virtual textures.</summary>
	public uint VirtualTextureFeedbackFactor;
	///<summary>Choose from list of provided working color spaces, or custom to provide user-defined space.</summary>
	public EWorkingColorSpace WorkingColorSpaceChoice;
	///<summary>Working color space red chromaticity coordinates.</summary>
	public FVector2D RedChromaticityCoordinate;
	///<summary>Working color space green chromaticity coordinates.</summary>
	public FVector2D GreenChromaticityCoordinate;
	///<summary>Working color space blue chromaticity coordinates.</summary>
	public FVector2D BlueChromaticityCoordinate;
	///<summary>Working color space white chromaticity coordinates.</summary>
	public FVector2D WhiteChromaticityCoordinate;
	///<summary>Use a separate normal map for the bottom layer of a clear coat material. This is a higher quality feature that is expensive.</summary>
	public bool bClearCoatEnableSecondNormal;
	///<summary>Dynamic Global Illumination Method</summary>
	public EDynamicGlobalIlluminationMethod DynamicGlobalIllumination;
	///<summary>Reflection Method</summary>
	public EReflectionMethod Reflections;
	///<summary>The cubemap resolution for all reflection capture probes. Must be power of 2. Note that for very high values the memory and performance impact may be severe.</summary>
	public int ReflectionCaptureResolution;
	///<summary>Whether to reduce lightmap mixing with reflection captures for very smooth surfaces.  This is useful to make sure reflection captures match SSR / planar reflections in brightness.</summary>
	public bool ReflectionEnvironmentLightmapMixBasedOnRoughness;
	///<summary>Uses Hardware Ray Tracing for Lumen features, when supported by the video card + RHI + Operating System. Lumen will fall back to Software Ray Tracing otherwise. Note: Hardware ray tracing has significant scene update costs for scenes with more than 100k instances.</summary>
	public bool bUseHardwareRayTracingForLumen;
	///<summary>Controls how Lumen Reflection rays are lit when Lumen is using Hardware Ray Tracing.  By default, Lumen uses the Surface Cache for best performance, but can be set to &#39;Hit Lighting&#39; for higher quality.</summary>
	public ELumenRayLightingMode LumenRayLightingMode;
	///<summary>Whether to use high quality mirror reflections on the front layer of translucent surfaces.  Other layers will use the lower quality Radiance Cache method that can only produce glossy reflections.  Increases GPU cost when enabled.</summary>
	public bool LumenFrontLayerTranslucencyReflections;
	///<summary>Controls which tracing method Lumen uses when using Software Ray Tracing.</summary>
	public ELumenSoftwareTracingMode LumenSoftwareTracingMode;
	///<summary>Select the primary shadow mapping method. Automatically uses &#39;Shadow Maps&#39; when Forward Shading is enabled for the project as Virtual Shadow Maps are not supported.</summary>
	public EShadowMapMethod ShadowMapMethod;
	///<summary>Support Hardware Ray Tracing features.  Requires &#39;Support Compute Skincache&#39; before project is allowed to set this.</summary>
	public bool bEnableRayTracing;
	///<summary>Controls whether Ray Traced Shadows are used by default. Lights can still override and force Ray Traced shadows on or off. Requires Hardware Ray Tracing to be enabled.</summary>
	public bool bEnableRayTracingShadows;
	///<summary>Controls whether Ray Traced Skylight is used by default. Skylights can still override and force Ray Traced Skylight on or off. Requires Hardware Ray Tracing to be enabled.  Has no effect when Dynamic Global Illumination Method is set to Lumen.</summary>
	public bool bEnableRayTracingSkylight;
	///<summary>Enable automatic texture mip level selection in ray tracing material shaders. Unchecked: highest resolution mip level is used for all texture (default). Checked: texture LOD is approximated based on total ray length, output resolution and texel density at hit point (ray cone method).</summary>
	public bool bEnableRayTracingTextureLOD;
	///<summary>Enables the Path Tracing renderer. This enables additional material permutations. Requires Hardware Ray Tracing to be enabled.</summary>
	public bool bEnablePathTracing;
	///<summary>Whether to build distance fields of static meshes, needed for Software Ray Tracing in Lumen, and distance field AO, which is used to implement Movable SkyLight shadows, and ray traced distance field shadows on directional lights.  Enabling will increase the build times, memory usage and disk size of static meshes.  Changing this setting requires restarting the editor.</summary>
	public bool bGenerateMeshDistanceFields;
	///<summary>Determines how the default scale of a mesh converts into distance field voxel dimensions. Changing this will cause all distance fields to be rebuilt.  Large values can consume memory very quickly!  Changing this setting requires restarting the editor.</summary>
	public float DistanceFieldVoxelDensity;
	///<summary>Whether to enable Nanite rendering.</summary>
	public bool bNanite;
	///<summary>Whether to allow any static lighting to be generated and used, like lightmaps and shadowmaps. Games that only use dynamic lighting should set this to 0 to save some static lighting overhead. Disabling allows Material AO and Material BentNormal to work with Lumen Global Illumination.  Changing this setting requires restarting the editor.</summary>
	public bool bAllowStaticLighting;
	///<summary>Whether to allow any static lighting to use normal maps for lighting computations.</summary>
	public bool bUseNormalMapsForStaticLighting;
	///<summary>Whether to use forward shading on desktop platforms, requires Shader Model 5 hardware.  Forward shading supports MSAA and has lower default cost, but fewer features supported overall.  Materials have to opt-in to more expensive features like high quality reflections.  Changing this setting requires restarting the editor.</summary>
	public bool bForwardShading;
	///<summary>Causes opaque materials to use per-vertex fogging, which costs slightly less.  Only supported with forward shading. Changing this setting requires restarting the editor.</summary>
	public bool bVertexFoggingForOpaque;
	///<summary>Allow translucency to be rendered to a separate render targeted and composited after depth of field. Prevents translucency from appearing out of focus.</summary>
	public bool bSeparateTranslucency;
	///<summary>The sort mode for translucent primitives, affecting how they are ordered and how they change order as the camera moves. Requires that Separate Translucency (under Postprocessing) is true.</summary>
	public ETranslucentSortPolicy TranslucentSortPolicy;
	///<summary>The axis that sorting will occur along when Translucent Sort Policy is set to SortAlongAxis.</summary>
	public FVector TranslucentSortAxis;
	///<summary>Set the level of fixed-foveation to apply when generating the Variable Rate Shading attachment. This feature is currently experimental.</summary>
	public EFixedFoveationLevels HMDFixedFoveationLevel;
	///<summary>Allows fixed foveation level to adjust dynamically based on GPU utilization.</summary>
	public bool bHMDFixedFoveationDynamic;
	///<summary>Whether the custom depth pass for tagging primitives for postprocessing passes is enabled. Enabling it on demand can save memory but may cause a hitch the first time the feature is used.</summary>
	public ECustomDepthStencil CustomDepthStencil;
	///<summary>Whether the custom depth pass has the TemporalAA jitter enabled. Disabling this can be useful when the result of the CustomDepth Pass is used after TAA (e.g. after Tonemapping)</summary>
	public bool bCustomDepthTaaJitter;
	///<summary>Configures alpha channel support in renderer&#39;s post processing chain. Still experimental: works only with Temporal AA, Motion Blur, Circle Depth Of Field. This option also force disable the separate translucency.</summary>
	public EAlphaChannelMode bEnableAlphaChannelInPostProcessing;
	///<summary>Whether the default for Bloom is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
	public bool bDefaultFeatureBloom;
	///<summary>Whether the default for AmbientOcclusion is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
	public bool bDefaultFeatureAmbientOcclusion;
	///<summary>Whether the default for AmbientOcclusionStaticFraction is enabled or not (only useful for baked lighting and if AO is on, allows to have SSAO affect baked lighting as well, costs performance, postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
	public bool bDefaultFeatureAmbientOcclusionStaticFraction;
	///<summary>Whether the default for AutoExposure is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
	public bool bDefaultFeatureAutoExposure;
	///<summary>The default method for AutoExposure(postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
	public EAutoExposureMethodUI DefaultFeatureAutoExposure;
	///<summary>Default Value for auto exposure bias.</summary>
	public float DefaultFeatureAutoExposureBias;
	///<summary>Whether the default values for AutoExposure should support an extended range of scene luminance. Also changes the exposure settings to be expressed in EV100. Having this setting disabled is deprecated and can only be done manually using r.DefaultFeature.AutoExposure.ExtendDefaultLuminanceRange.</summary>
	public bool bExtendDefaultLuminanceRangeInAutoExposureSettings;
	///<summary>Whether the default for MotionBlur is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
	public bool bDefaultFeatureMotionBlur;
	///<summary>Whether the default for LensFlare is enabled or not (postprocess volume/camera/game setting can still override and enable or disable it independently)</summary>
	public bool bDefaultFeatureLensFlare;
	///<summary>Whether to do primary screen percentage upscale with Temporal AA pass or not.</summary>
	public bool bTemporalUpsampling;
	///<summary>Selects the anti-aliasing method to use.</summary>
	public EAntiAliasingMethod DefaultFeatureAntiAliasing;
	///<summary>Default number of samples for MSAA.</summary>
	public ECompositingSampleCount MSAASampleCount;
	///<summary>Which units to use for newly placed point, spot and rect lights</summary>
	public ELightUnits DefaultLightUnits;
	///<summary>Pixel format used for back buffer, when not specified</summary>
	public EDefaultBackBufferPixelFormat DefaultBackBufferPixelFormat;
	///<summary>Whether to render unbuilt preview shadows in game.  When enabled and lighting is not built, expensive preview shadows will be rendered in game.  When disabled, lighting in game and editor won&#39;t match which can appear to be a bug.</summary>
	public bool bRenderUnbuiltPreviewShadowsInGame;
	///<summary>Whether to use stencil for LOD dither fading.  This saves GPU time in the base pass for materials with dither fading enabled, but forces a full prepass. Changing this setting requires restarting the editor.</summary>
	public bool bStencilForLODDither;
	///<summary>Whether to use a depth only pass to initialize Z culling for the base pass.</summary>
	public EEarlyZPass EarlyZPass;
	///<summary>Whether to compute materials&#39; mask opacity only in early Z pass. Changing this setting requires restarting the editor.</summary>
	public bool bEarlyZPassOnlyMaterialMasking;
	///<summary>Enable caching CSM to reduce draw calls for casting CSM and probably improve performance.</summary>
	public bool bEnableCSMCaching;
	///<summary>Whether to accumulate decal properties to a buffer before the base pass.  DBuffer decals correctly affect lightmap and sky lighting, unlike regular deferred decals.  DBuffer enabled forces a full prepass.  Changing this setting requires restarting the editor.</summary>
	public bool bDBuffer;
	///<summary>Select how the g-buffer is cleared in game mode (only affects deferred shading).</summary>
	public EClearSceneOptions ClearSceneMethod;
	///<summary>When to write velocity buffer. Changing this setting requires restarting the editor.</summary>
	public EVelocityOutputPass VelocityPass;
	///<summary>Enables materials with World Position Offset and/or World Displacement to output velocities during the velocity pass even when the actor has not moved. </summary>
	public EVertexDeformationOutputsVelocity VertexDeformationOutputsVelocity;
	///<summary>Enables not exporting to the GBuffer rendertargets that are not relevant. Changing this setting requires restarting the editor.</summary>
	public bool bSelectiveBasePassOutputs;
	///<summary>When enabled, after changing the material on a Required particle module a Particle Cutout texture will be chosen automatically from the Opacity Mask texture if it exists, if not the Opacity Texture will be used if it exists.</summary>
	public bool bDefaultParticleCutouts;
	///<summary>The X size of the GPU simulation texture size. SizeX*SizeY determines the maximum number of GPU simulated particles in an emitter. Potentially overridden by CVar settings in BaseDeviceProfile.ini.</summary>
	public int GPUSimulationTextureSizeX;
	///<summary>The Y size of the GPU simulation texture size. SizeX*SizeY determines the maximum number of GPU simulated particles in an emitter. Potentially overridden by CVar settings in BaseDeviceProfile.ini.</summary>
	public int GPUSimulationTextureSizeY;
	///<summary>Whether to support the global clip plane needed for planar reflections.  Enabling this increases BasePass triangle cost by ~15% regardless of whether planar reflections are active. Changing this setting requires restarting the editor.</summary>
	public bool bGlobalClipPlane;
	///<summary>Selects which GBuffer format should be used. Affects performance primarily via how much GPU memory bandwidth used. This also controls Substrate normal quality and, in this case, a restart is required.</summary>
	public EGBufferFormat GBufferFormat;
	///<summary>Whether to use original CPU method (loop per morph then by vertex) or use a GPU-based method on Shader Model 5 hardware.</summary>
	public bool bUseGPUMorphTargets;
	///<summary>Enables vendor specific GPU crash analysis tools.</summary>
	public bool bNvidiaAftermathEnabled;
	///<summary>Enable single-pass stereoscopic rendering through view instancing or draw call instancing.</summary>
	public bool bMultiView;
	///<summary>If true, mobile pipelines include a full post-processing pass with tonemapping. Disable this setting for a performance boost and to enable stereoscopic rendering optimizations. Changing this setting requires restarting the editor.</summary>
	public bool bMobilePostProcessing;
	///<summary>Enable single-pass stereoscopic rendering on mobile platforms.</summary>
	public bool bMobileMultiView;
	///<summary>If true then mobile single-pass (without post-processing) rendering will use HW accelerated sRGB encoding/decoding. Available only on Oculus for now.</summary>
	public bool bMobileUseHWsRGBEncoding;
	///<summary>Enable round-robin scheduling of occlusion queries for VR.</summary>
	public bool bRoundRobinOcclusion;
	///<summary>When enabled mesh will stream in based on what is visible on screen.</summary>
	public bool bMeshStreaming;
	///<summary>Enable rendering with the heterogeneous volumes subsystem.</summary>
	public bool bEnableHeterogeneousVolumes;
	///<summary>Screen radius at which wireframe objects are culled. Larger values can improve performance when viewing a scene in wireframe.</summary>
	public float WireframeCullThreshold;
	///<summary>&quot;Stationary skylight requires permutations of the basepass shaders.  Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor.&quot;</summary>
	public bool bSupportStationarySkylight;
	///<summary>&quot;Low quality lightmap requires permutations of the lightmap rendering shaders.  Disabling will reduce the number of shader permutations required per material. Note that the mobile renderer requires low quality lightmaps, so disabling this setting is not recommended for mobile titles using static lighting. Changing this setting requires restarting the editor.&quot;</summary>
	public bool bSupportLowQualityLightmaps;
	///<summary>PointLight WholeSceneShadows requires many vertex and geometry shader permutations for cubemap rendering. Disabling will reduce the number of shader permutations required per material. Changing this setting requires restarting the editor.&quot;</summary>
	public bool bSupportPointLightWholeSceneShadows;
	///<summary>The sky atmosphere component requires extra samplers/textures to be bound to apply aerial perspective on transparent surfaces (and all surfaces on mobile via per vertex evaluation).</summary>
	public bool bSupportSkyAtmosphere;
	///<summary>The sky atmosphere component can light up the height fog but it requires extra samplers/textures to be bound to apply aerial perspective on transparent surfaces (and all surfaces on mobile via per vertex evaluation). It requires r.SupportSkyAtmosphere to be true.</summary>
	public bool bSupportSkyAtmosphereAffectsHeightFog;
	///<summary>Enable cloud shadow on translucent surface not relying on the translucenct lighting volume, e.g. using Forward lighting. This is evaluated per vertex to reduce GPU cost and requires extra samplers/textures to be bound to vertex shaders. This is not implemented on mobile as VolumetricClouds are not available on these platforms.</summary>
	public bool bSupportCloudShadowOnForwardLitTranslucent;
	///<summary>Enable translucent volumetric self-shadow, requires vertex and pixel shader permutations for all tranlucent materials even if not used by any light.</summary>
	public bool bSupportTranslucentPerObjectShadow;
	///<summary>Enable cloud shadow on SingleLayerWater. This is evaluated per vertex to reduce GPU cost and requires extra samplers/textures to be bound to vertex shaders. This is not implemented on mobile as VolumetricClouds are not available on these platforms.</summary>
	public bool bSupportCloudShadowOnSingleLayerWater;
	///<summary>Enable Substrate materials (Experimental).</summary>
	public bool bEnableStrata;
	///<summary>Enable Substrate opaque material rough refractions effect from top layers over layers below.</summary>
	public bool StrataOpaqueMaterialRoughRefraction;
	///<summary>Enable advanced Substrate material debug visualization shaders. Base pass shaders can output such advanced data.</summary>
	public bool StrataDebugAdvancedVisualizationShaders;
	///<summary>Enable Rough Diffuse Material.</summary>
	public bool bMaterialRoughDiffuse;
	///<summary>Enable Energy Conservation on Material. Please note that when Substrate is enabled, energy conservation is forced to enabled.</summary>
	public bool bMaterialEnergyConservation;
	///<summary>Enable support for Order-Independent-Transparency on translucent surfaces, which remove most of the sorting artifact among translucent surfaces.</summary>
	public bool bOrderedIndependentTransparencyEnable;
	///<summary>Cannot be disabled while Ray Tracing is enabled as it is then required.</summary>
	public bool bSupportSkinCacheShaders;
	///<summary>Cannot be enabled while the skin cache is turned off.</summary>
	public bool bSkipCompilingGPUSkinVF;
	///<summary>Default behavior if all skeletal meshes are included/excluded from the skin cache. If Support Ray Tracing is enabled on a mesh, the skin cache will be used for Ray Tracing updates on that mesh regardless of this setting.</summary>
	public ESkinCacheDefaultBehavior DefaultSkinCacheBehavior;
	///<summary>Maximum amount of memory (in MB) per world/scene allowed for the Compute Skin Cache to generate output vertex data and recompute tangents.</summary>
	public float SkinCacheSceneMemoryLimitInMB;
	///<summary>Allow primitives to receive both static and CSM shadows from a stationary light. Disabling will free a mobile texture sampler and reduce shader permutations. Changing this setting requires restarting the editor.</summary>
	public bool bMobileEnableStaticAndCSMShadowReceivers;
	///<summary>Primitives lit by a movable directional light will render with the CSM shader only when determined to be within CSM range. Changing this setting requires restarting the editor.</summary>
	public bool bMobileEnableMovableLightCSMShaderCulling;
	///<summary>Enable local lights support for mobile forward shading (including translucency in deferred). 0 is disabled, 1 is enabled (default). Changing this setting requires restarting the editor.</summary>
	public bool bMobileForwardEnableLocalLights;
	///<summary>Whether to enable clustered reflections on mobile forward (including translucency in deferred). Always supported for opaque geometry on mobile deferred. Changing this setting requires restarting the editor.</summary>
	public bool bMobileForwardEnableClusteredReflections;
	///<summary>When Allow Static Lighting is enabled, shaders to support CSM without any precomputed lighting are not normally generated. This setting allows CSM for this case at the cost of extra shader permutations. Changing this setting requires restarting the editor.</summary>
	public bool bMobileEnableNoPrecomputedLightingCSMShader;
	///<summary>Generate shaders for static primitives render Lightmass-baked distance field shadow maps from stationary directional lights. Changing this setting requires restarting the editor.</summary>
	public bool bMobileAllowDistanceFieldShadows;
	///<summary>Generate shaders for primitives to receive movable directional lights. Changing this setting requires restarting the editor.</summary>
	public bool bMobileAllowMovableDirectionalLights;
	///<summary>Generate shaders for primitives to receive shadow from movable spotlights. Changing this setting requires restarting the editor.</summary>
	public bool bMobileAllowMovableSpotlightShadows;
	///<summary>If enabled, a new mesh imported will use 8 bit (if &lt;=256 bones) or 16 bit (if &gt; 256 bones) bone indices for rendering.</summary>
	public bool bSupport16BitBoneIndex;
	///<summary>Whether to use 2 bone influences instead of the default of 4 for GPU skinning. This does not change skeletal mesh assets but reduces the number of instructions required by the GPU skin vertex shaders. Changing this setting requires restarting the editor.</summary>
	public bool bGPUSkinLimit2BoneInfluences;
	///<summary>Support depth-only index buffers, which provide a minor rendering speedup at the expense of using twice the index buffer memory.</summary>
	public bool bSupportDepthOnlyIndexBuffers;
	///<summary>Support reversed index buffers, which provide a minor rendering speedup at the expense of using twice the index buffer memory.</summary>
	public bool bSupportReversedIndexBuffers;
	///<summary>Mobile Ambient Occlusion. Causion: An extra sampler will be occupied in mobile base pass pixel shader after enable the mobile ambient occlusion. Changing this setting requires restarting the editor.</summary>
	public bool bMobileAmbientOcclusion;
	///<summary>If enabled, a new mesh imported will use unlimited bone buffer instead of fixed MaxBoneInfluences for rendering.</summary>
	public bool bUseUnlimitedBoneInfluences;
	///<summary>When Unlimited Bone Influence is enabled, it still uses a fixed bone inflence buffer until the max bone influence of a mesh exceeds this value</summary>
	public int UnlimitedBonInfluencesThreshold;
	///<summary>When BoneInfluenceLimit on a skeletal mesh LOD is set to 0, this setting is used instead. If this setting is 0, no limit will be applied here and the max bone influences will be determined by other project settings. Changing this setting requires restarting the editor.</summary>
	public FPerPlatformInt DefaultBoneInfluenceLimit;
	///<summary>Max number of bones that can be skinned on the GPU in a single draw call. The default value is set by the Compat.MAX_GPUSKIN_BONES consolevariable. Changing this setting requires restarting the editor.</summary>
	public FPerPlatformInt MaxSkinBones;
	///<summary>The PlanarReflection will work differently on different mode on mobile platform, choose the proper mode as expect. Changing this setting requires restarting the editor.</summary>
	public EMobilePlanarReflectionMode MobilePlanarReflectionMode;
	///<summary>Support desktop Gen4 TAA with mobile rendering. Changing this setting requires restarting the editor.</summary>
	public bool bMobileSupportsGen4TAA;
	///<summary>Whether to stream skeletal mesh LODs by default.</summary>
	public FPerPlatformBool bStreamSkeletalMeshLODs;
	///<summary>Whether to discard skeletal mesh LODs below minimum LOD levels at cook time.</summary>
	public FPerPlatformBool bDiscardSkeletalMeshOptionalLODs;
	///<summary>When the VisualizeCalibrationColor show flag is enabled, this path will be used as the post-process material to render. The post-process material&#39;s Blendable Location property must be set to &quot;After Tonemapping&quot; for proper calibration display.</summary>
	public FSoftObjectPath VisualizeCalibrationColorMaterialPath;
	///<summary>When the VisualizeCalibrationCustom show flag is enabled, this path will be used as the post-process material to render. The post-process material&#39;s Blendable Location property must be set to &quot;After Tonemapping&quot; for proper calibration display.</summary>
	public FSoftObjectPath VisualizeCalibrationCustomMaterialPath;
	///<summary>When the VisualizeCalibrationGrayscale show flag is enabled, this path will be used as the post-process material to render. The post-process material&#39;s Blendable Location property must be set to &quot;After Tonemapping&quot; for proper calibration display.</summary>
	public FSoftObjectPath VisualizeCalibrationGrayscaleMaterialPath;
}

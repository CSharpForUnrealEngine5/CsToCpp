#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class of all Engine classes, responsible for management of systems critical to editor or game systems.</summary>
[CppInclude("Engine/Engine.h")]
public partial class UEngine : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TinyFont</summary>
	public UFont TinyFont;
	///<summary>Sets the font used for the smallest engine text</summary>
	public FSoftObjectPath TinyFontName;
	///<summary>SmallFont</summary>
	public UFont SmallFont;
	///<summary>Sets the font used for small engine text, used for most debug displays</summary>
	public FSoftObjectPath SmallFontName;
	///<summary>MediumFont</summary>
	public UFont MediumFont;
	///<summary>Sets the font used for medium engine text</summary>
	public FSoftObjectPath MediumFontName;
	///<summary>LargeFont</summary>
	public UFont LargeFont;
	///<summary>Sets the font used for large engine text</summary>
	public FSoftObjectPath LargeFontName;
	///<summary>SubtitleFont</summary>
	public UFont SubtitleFont;
	///<summary>Sets the font used by the default Subtitle Manager</summary>
	public FSoftObjectPath SubtitleFontName;
	///<summary>AdditionalFonts</summary>
	public TArray<UFont> AdditionalFonts;
	///<summary>Sets additional fonts that will be loaded at startup and available using GetAdditionalFont.</summary>
	public TArray<string> AdditionalFontNames;
	///<summary>ConsoleClass</summary>
	public UClass ConsoleClass;
	///<summary>Sets the class to use for the game console summoned with ~</summary>
	public FSoftClassPath ConsoleClassName;
	///<summary>GameViewportClientClass</summary>
	public UClass GameViewportClientClass;
	///<summary>Sets the class to use for the game viewport client, which can be overridden to change game-specific input and display behavior.</summary>
	public FSoftClassPath GameViewportClientClassName;
	///<summary>LocalPlayerClass</summary>
	public UClass LocalPlayerClass;
	///<summary>Sets the class to use for local players, which can be overridden to store game-specific information for a local player.</summary>
	public FSoftClassPath LocalPlayerClassName;
	///<summary>WorldSettingsClass</summary>
	public UClass WorldSettingsClass;
	///<summary>Sets the class to use for WorldSettings, which can be overridden to store game-specific information on map/world.</summary>
	public FSoftClassPath WorldSettingsClassName;
	///<summary>NavigationSystemClassName</summary>
	public FSoftClassPath NavigationSystemClassName;
	///<summary>Sets the class to use for NavigationSystem, which can be overridden to change game-specific navigation/AI behavior.</summary>
	public UClass NavigationSystemClass;
	///<summary>Sets the Navigation System Config class, which can be overridden to change game-specific navigation/AI behavior.</summary>
	public FSoftClassPath NavigationSystemConfigClassName;
	///<summary>NavigationSystemConfigClass</summary>
	public UClass NavigationSystemConfigClass;
	///<summary>Sets the AvoidanceManager class, which can be overridden to change AI crowd behavior.</summary>
	public FSoftClassPath AvoidanceManagerClassName;
	///<summary>AvoidanceManagerClass</summary>
	public UClass AvoidanceManagerClass;
	///<summary>Sets the class to be used as the default AIController class for pawns.</summary>
	public FSoftClassPath AIControllerClassName;
	///<summary>PhysicsCollisionHandlerClass</summary>
	public UClass PhysicsCollisionHandlerClass;
	///<summary>Sets the PhysicsCollisionHandler class to use by default, which can be overridden to change game-specific behavior when objects collide using physics.</summary>
	public FSoftClassPath PhysicsCollisionHandlerClassName;
	///<summary>Sets the GameUserSettings class, which can be overridden to support game-specific options for Graphics/Sound/Gameplay.</summary>
	public FSoftClassPath GameUserSettingsClassName;
	///<summary>GameUserSettingsClass</summary>
	public UClass GameUserSettingsClass;
	///<summary>Global instance of the user game settings</summary>
	public UGameUserSettings GameUserSettings;
	///<summary>LevelScriptActorClass</summary>
	public UClass LevelScriptActorClass;
	///<summary>Sets the Level Script Actor class, which can be overridden to allow game-specific behavior in per-map blueprint scripting</summary>
	public FSoftClassPath LevelScriptActorClassName;
	///<summary>Sets the base class to use for new blueprints created in the editor, configurable on a per-game basis</summary>
	public FSoftClassPath DefaultBlueprintBaseClassName;
	///<summary>Sets the class for a global object spawned at startup to handle game-specific data. If empty, it will not spawn one</summary>
	public FSoftClassPath GameSingletonClassName;
	///<summary>A UObject spawned at initialization time to handle game-specific data</summary>
	public UObject GameSingleton;
	///<summary>Sets the class to spawn as the global AssetManager, configurable per game. If empty, it will not spawn one</summary>
	public FSoftClassPath AssetManagerClassName;
	///<summary>A UObject spawned at initialization time to handle runtime asset loading and management</summary>
	public UAssetManager AssetManager;
	///<summary>A global default texture.</summary>
	public UTexture2D DefaultTexture;
	///<summary>Path of the global default texture that is used when no texture is specified.</summary>
	public FSoftObjectPath DefaultTextureName;
	///<summary>A global default diffuse texture.</summary>
	public UTexture DefaultDiffuseTexture;
	///<summary>Path of the global default diffuse texture.</summary>
	public FSoftObjectPath DefaultDiffuseTextureName;
	///<summary>Texture used to render a vertex in the editor</summary>
	public UTexture2D DefaultBSPVertexTexture;
	///<summary>Path of the texture used to render a vertex in the editor</summary>
	public FSoftObjectPath DefaultBSPVertexTextureName;
	///<summary>Texture used to get random image grain values for post processing</summary>
	public UTexture2D HighFrequencyNoiseTexture;
	///<summary>Path of the texture used to get random image grain values for post processing</summary>
	public FSoftObjectPath HighFrequencyNoiseTextureName;
	///<summary>Texture used to blur out of focus content, mimics the Bokeh shape of actual cameras</summary>
	public UTexture2D DefaultBokehTexture;
	///<summary>Path of the texture used to blur out of focus content, mimics the Bokeh shape of actual cameras</summary>
	public FSoftObjectPath DefaultBokehTextureName;
	///<summary>Texture used to bloom when using FFT, mimics characteristic bloom produced in a camera from a signle bright source</summary>
	public UTexture2D DefaultBloomKernelTexture;
	///<summary>Path of the texture used to bloom when using FFT, mimics characteristic bloom produced in a camera from a signle bright source</summary>
	public FSoftObjectPath DefaultBloomKernelTextureName;
	///<summary>Texture used to film grain by default.</summary>
	public UTexture2D DefaultFilmGrainTexture;
	///<summary>Path of the texture used by film grain by default.</summary>
	public FSoftObjectPath DefaultFilmGrainTextureName;
	///<summary>The material used to render wireframe meshes.</summary>
	public UMaterial WireframeMaterial;
	///<summary>Path of the material used to render wireframe meshes in the editor and debug tools.</summary>
	public string WireframeMaterialName;
	///<summary>A translucent material used to render things in geometry mode.</summary>
	public UMaterial GeomMaterial;
	///<summary>Path of the translucent material used to render things in geometry mode.</summary>
	public FSoftObjectPath GeomMaterialName;
	///<summary>A material used to render debug meshes.</summary>
	public UMaterial DebugMeshMaterial;
	///<summary>Path of the default material for debug mesh</summary>
	public FSoftObjectPath DebugMeshMaterialName;
	///<summary>Material used for removing Nanite mesh sections from rasterization.</summary>
	public UMaterial NaniteHiddenSectionMaterial;
	///<summary>Path of the material used for removing Nanite mesh sections from rasterization.</summary>
	public string NaniteHiddenSectionMaterialName;
	///<summary>A material used to render emissive meshes (e.g. light source surface).</summary>
	public UMaterial EmissiveMeshMaterial;
	///<summary>Path of the default material for emissive mesh</summary>
	public FSoftObjectPath EmissiveMeshMaterialName;
	///<summary>Material used for visualizing level membership in lit view port modes.</summary>
	public UMaterial LevelColorationLitMaterial;
	///<summary>Path of the material used for visualizing level membership in lit view port modes.</summary>
	public string LevelColorationLitMaterialName;
	///<summary>Material used for visualizing level membership in unlit view port modes.</summary>
	public UMaterial LevelColorationUnlitMaterial;
	///<summary>Path of the material used for visualizing level membership in unlit view port modes.</summary>
	public string LevelColorationUnlitMaterialName;
	///<summary>Material used for visualizing lighting only w/ lightmap texel density.</summary>
	public UMaterial LightingTexelDensityMaterial;
	///<summary>Path of the material used for visualizing lighting only w/ lightmap texel density.</summary>
	public string LightingTexelDensityName;
	///<summary>Material used for visualizing level membership in lit view port modes. Uses shading to show axis directions.</summary>
	public UMaterial ShadedLevelColorationLitMaterial;
	///<summary>Path of the material used for visualizing level membership in lit view port modes. Uses shading to show axis directions.</summary>
	public string ShadedLevelColorationLitMaterialName;
	///<summary>Material used for visualizing level membership in unlit view port modes.  Uses shading to show axis directions.</summary>
	public UMaterial ShadedLevelColorationUnlitMaterial;
	///<summary>Path of the material used for visualizing level membership in unlit view port modes.  Uses shading to show axis directions.</summary>
	public string ShadedLevelColorationUnlitMaterialName;
	///<summary>Material used to indicate that the associated BSP surface should be removed.</summary>
	public UMaterial RemoveSurfaceMaterial;
	///<summary>Path of the material used to indicate that the associated BSP surface should be removed.</summary>
	public FSoftObjectPath RemoveSurfaceMaterialName;
	///<summary>Material used to visualize vertex colors as emissive</summary>
	public UMaterial VertexColorMaterial;
	///<summary>Path of the material used to visualize vertex colors as emissive</summary>
	public string VertexColorMaterialName;
	///<summary>Material for visualizing vertex colors on meshes in the scene (color only, no alpha)</summary>
	public UMaterial VertexColorViewModeMaterial_ColorOnly;
	///<summary>Path of the material for visualizing vertex colors on meshes in the scene (color only, no alpha)</summary>
	public string VertexColorViewModeMaterialName_ColorOnly;
	///<summary>Material for visualizing vertex colors on meshes in the scene (alpha channel as color)</summary>
	public UMaterial VertexColorViewModeMaterial_AlphaAsColor;
	///<summary>Path of the material for visualizing vertex colors on meshes in the scene (alpha channel as color)</summary>
	public string VertexColorViewModeMaterialName_AlphaAsColor;
	///<summary>Material for visualizing vertex colors on meshes in the scene (red only)</summary>
	public UMaterial VertexColorViewModeMaterial_RedOnly;
	///<summary>Path of the material for visualizing vertex colors on meshes in the scene (red only)</summary>
	public string VertexColorViewModeMaterialName_RedOnly;
	///<summary>Material for visualizing vertex colors on meshes in the scene (green only)</summary>
	public UMaterial VertexColorViewModeMaterial_GreenOnly;
	///<summary>Path of the material for visualizing vertex colors on meshes in the scene (green only)</summary>
	public string VertexColorViewModeMaterialName_GreenOnly;
	///<summary>Material for visualizing vertex colors on meshes in the scene (blue only)</summary>
	public UMaterial VertexColorViewModeMaterial_BlueOnly;
	///<summary>Path of the material for visualizing vertex colors on meshes in the scene (blue only)</summary>
	public string VertexColorViewModeMaterialName_BlueOnly;
	///<summary>Material used to render bone weights on skeletal meshes</summary>
	public UMaterial BoneWeightMaterial;
	///<summary>Path of the material used to render bone weights on skeletal meshes</summary>
	public FSoftObjectPath BoneWeightMaterialName;
	///<summary>Materials used to render cloth properties on skeletal meshes</summary>
	public UMaterial ClothPaintMaterial;
	///<summary>ClothPaintMaterialWireframe</summary>
	public UMaterial ClothPaintMaterialWireframe;
	///<summary>ClothPaintMaterialInstance</summary>
	public UMaterialInstanceDynamic ClothPaintMaterialInstance;
	///<summary>ClothPaintMaterialWireframeInstance</summary>
	public UMaterialInstanceDynamic ClothPaintMaterialWireframeInstance;
	///<summary>Name of the material used to render cloth in the clothing tools</summary>
	public FSoftObjectPath ClothPaintMaterialName;
	///<summary>Name of the material used to render cloth wireframe in the clothing tools</summary>
	public FSoftObjectPath ClothPaintMaterialWireframeName;
	///<summary>A material used to render physical material mask on mesh.</summary>
	public UMaterial PhysicalMaterialMaskMaterial;
	///<summary>A material used to render physical material mask on mesh.</summary>
	public FSoftObjectPath PhysicalMaterialMaskMaterialName;
	///<summary>A material used to render debug meshes.</summary>
	public UMaterial DebugEditorMaterial;
	///<summary>A material used to flatten materials.</summary>
	public FSoftObjectPath DefaultFlattenMaterialName;
	///<summary>A material used to flatten materials to VT textures.</summary>
	public FSoftObjectPath DefaultHLODFlattenMaterialName;
	///<summary>A material used to flatten materials to VT textures, with the normals being in world space.</summary>
	public FSoftObjectPath DefaultLandscapeFlattenMaterialName;
	///<summary>Materials used when flattening materials</summary>
	public UMaterial DefaultFlattenMaterial;
	///<summary>DefaultHLODFlattenMaterial</summary>
	public UMaterial DefaultHLODFlattenMaterial;
	///<summary>DefaultLandscapeFlattenMaterial</summary>
	public UMaterial DefaultLandscapeFlattenMaterial;
	///<summary>A material used to render debug opaque material. Used in various animation editor viewport features.</summary>
	public FSoftObjectPath DebugEditorMaterialName;
	///<summary>Material used to render constraint limits</summary>
	public UMaterial ConstraintLimitMaterial;
	///<summary>ConstraintLimitMaterialX</summary>
	public UMaterialInstanceDynamic ConstraintLimitMaterialX;
	///<summary>ConstraintLimitMaterialXAxis</summary>
	public UMaterialInstanceDynamic ConstraintLimitMaterialXAxis;
	///<summary>ConstraintLimitMaterialY</summary>
	public UMaterialInstanceDynamic ConstraintLimitMaterialY;
	///<summary>ConstraintLimitMaterialYAxis</summary>
	public UMaterialInstanceDynamic ConstraintLimitMaterialYAxis;
	///<summary>ConstraintLimitMaterialZ</summary>
	public UMaterialInstanceDynamic ConstraintLimitMaterialZ;
	///<summary>ConstraintLimitMaterialZAxis</summary>
	public UMaterialInstanceDynamic ConstraintLimitMaterialZAxis;
	///<summary>ConstraintLimitMaterialPrismatic</summary>
	public UMaterialInstanceDynamic ConstraintLimitMaterialPrismatic;
	///<summary>Material that renders a message about lightmap settings being invalid.</summary>
	public UMaterial InvalidLightmapSettingsMaterial;
	///<summary>Path of the material that renders a message about lightmap settings being invalid.</summary>
	public FSoftObjectPath InvalidLightmapSettingsMaterialName;
	///<summary>Material that renders a message about preview shadows being used.</summary>
	public UMaterial PreviewShadowsIndicatorMaterial;
	///<summary>Path of the material that renders a message about preview shadows being used.</summary>
	public FSoftObjectPath PreviewShadowsIndicatorMaterialName;
	///<summary>Material that &#39;fakes&#39; lighting, used for arrows, widgets.</summary>
	public UMaterial ArrowMaterial;
	///<summary>Arrow material instance with yellow color.</summary>
	public UMaterialInstanceDynamic ArrowMaterialYellow;
	///<summary>Path of the material that &#39;fakes&#39; lighting, used for arrows, widgets.</summary>
	public FSoftObjectPath ArrowMaterialName;
	///<summary>Color used for the lighting only render mode</summary>
	public FLinearColor LightingOnlyBrightness;
	///<summary>The colors used to render shader complexity.</summary>
	public TArray<FLinearColor> ShaderComplexityColors;
	///<summary>The colors used to render quad complexity.</summary>
	public TArray<FLinearColor> QuadComplexityColors;
	///<summary>The colors used to render light complexity.</summary>
	public TArray<FLinearColor> LightComplexityColors;
	///<summary>The colors used to render stationary light overlap.</summary>
	public TArray<FLinearColor> StationaryLightOverlapColors;
	///<summary>The colors used to render LOD coloration.</summary>
	public TArray<FLinearColor> LODColorationColors;
	///<summary>The colors used to render LOD coloration.</summary>
	public TArray<FLinearColor> HLODColorationColors;
	///<summary>The colors used for texture streaming accuracy debug view modes.</summary>
	public TArray<FLinearColor> StreamingAccuracyColors;
	///<summary>The visualization color when sk mesh not using skin cache.</summary>
	public FLinearColor GPUSkinCacheVisualizationExcludedColor;
	///<summary>The visualization color when sk mesh using skin cache.</summary>
	public FLinearColor GPUSkinCacheVisualizationIncludedColor;
	///<summary>The visualization color when sk mesh using recompute tangents.</summary>
	public FLinearColor GPUSkinCacheVisualizationRecomputeTangentsColor;
	///<summary>The memory visualization threshold in MB for a skin cache entry</summary>
	public float GPUSkinCacheVisualizationLowMemoryThresholdInMB;
	///<summary>GPUSkinCacheVisualizationHighMemoryThresholdInMB</summary>
	public float GPUSkinCacheVisualizationHighMemoryThresholdInMB;
	///<summary>The memory visualization colors of skin cache</summary>
	public FLinearColor GPUSkinCacheVisualizationLowMemoryColor;
	///<summary>GPUSkinCacheVisualizationMidMemoryColor</summary>
	public FLinearColor GPUSkinCacheVisualizationMidMemoryColor;
	///<summary>GPUSkinCacheVisualizationHighMemoryColor</summary>
	public FLinearColor GPUSkinCacheVisualizationHighMemoryColor;
	///<summary>The visualization colors of ray tracing LOD index offset from raster LOD</summary>
	public TArray<FLinearColor> GPUSkinCacheVisualizationRayTracingLODOffsetColors;
	///<summary>Complexity limits for the various complexity view mode combinations.</summary>
	public float MaxPixelShaderAdditiveComplexityCount;
	///<summary>MaxES3PixelShaderAdditiveComplexityCount</summary>
	public float MaxES3PixelShaderAdditiveComplexityCount;
	///<summary>Minimum lightmap density value for coloring.</summary>
	public float MinLightMapDensity;
	///<summary>Ideal lightmap density value for coloring.</summary>
	public float IdealLightMapDensity;
	///<summary>Maximum lightmap density value for coloring.</summary>
	public float MaxLightMapDensity;
	///<summary>If true, then render gray scale density.</summary>
	public bool bRenderLightMapDensityGrayscale;
	///<summary>The scale factor when rendering gray scale density.</summary>
	public float RenderLightMapDensityGrayscaleScale;
	///<summary>The scale factor when rendering color density.</summary>
	public float RenderLightMapDensityColorScale;
	///<summary>The color to render vertex mapped objects in for LightMap Density view mode.</summary>
	public FLinearColor LightMapDensityVertexMappedColor;
	///<summary>The color to render selected objects in for LightMap Density view mode.</summary>
	public FLinearColor LightMapDensitySelectedColor;
	///<summary>Colors used to display specific profiling stats</summary>
	public TArray<FStatColorMapping> StatColorMappings;
	///<summary>A material used to render the sides of the builder brush/volumes/etc.</summary>
	public UMaterial EditorBrushMaterial;
	///<summary>Path of the material used to render the sides of the builder brush/volumes/etc.</summary>
	public FSoftObjectPath EditorBrushMaterialName;
	///<summary>PhysicalMaterial to use if none is defined for a particular object.</summary>
	public UPhysicalMaterial DefaultPhysMaterial;
	///<summary>Path of the PhysicalMaterial to use if none is defined for a particular object.</summary>
	public FSoftObjectPath DefaultPhysMaterialName;
	///<summary>PhysicalMaterial to use if none is defined for a Destructible object.</summary>
	public UPhysicalMaterial DefaultDestructiblePhysMaterial;
	///<summary>Path of the PhysicalMaterial to use if none is defined for a particular object.</summary>
	public FSoftObjectPath DefaultDestructiblePhysMaterialName;
	///<summary>Deprecated rules for redirecting renamed objects, replaced by the CoreRedirects system</summary>
	public TArray<FGameNameRedirect> ActiveGameNameRedirects;
	///<summary>ActiveClassRedirects</summary>
	public TArray<FClassRedirect> ActiveClassRedirects;
	///<summary>ActivePluginRedirects</summary>
	public TArray<FPluginRedirect> ActivePluginRedirects;
	///<summary>ActiveStructRedirects</summary>
	public TArray<FStructRedirect> ActiveStructRedirects;
	///<summary>Texture used for pre-integrated skin shading</summary>
	public UTexture2D PreIntegratedSkinBRDFTexture;
	///<summary>Path of the texture used for pre-integrated skin shading</summary>
	public FSoftObjectPath PreIntegratedSkinBRDFTextureName;
	///<summary>Tiled blue-noise texture</summary>
	public UTexture2D BlueNoiseScalarTexture;
	///<summary>Spatial-temporal blue noise texture with two channel output</summary>
	public UTexture2D BlueNoiseVec2Texture;
	///<summary>Path of the tiled blue-noise texture</summary>
	public FSoftObjectPath BlueNoiseScalarTextureName;
	///<summary>Path of the tiled blue-noise texture</summary>
	public FSoftObjectPath BlueNoiseVec2TextureName;
	///<summary>Texture used to do font rendering in shaders</summary>
	public UTexture2D MiniFontTexture;
	///<summary>Path of the texture used to do font rendering in shaders</summary>
	public FSoftObjectPath MiniFontTextureName;
	///<summary>Texture used as a placeholder for terrain weight-maps to give the material the correct texture format.</summary>
	public UTexture WeightMapPlaceholderTexture;
	///<summary>Path of the texture used as a placeholder for terrain weight-maps to give the material the correct texture format.</summary>
	public FSoftObjectPath WeightMapPlaceholderTextureName;
	///<summary>Texture used to display LightMapDensity</summary>
	public UTexture2D LightMapDensityTexture;
	///<summary>Path of the texture used to display LightMapDensity</summary>
	public FSoftObjectPath LightMapDensityTextureName;
	///<summary>The view port representing the current game instance. Can be 0 so don&#39;t use without checking.</summary>
	public UGameViewportClient GameViewport;
	///<summary>Array of deferred command strings/ execs that get executed at the end of the frame</summary>
	public TArray<string> DeferredCommands;
	///<summary>The distance of the camera&#39;s near clipping plane.</summary>
	public float NearClipPlane;
	///<summary>Flag for completely disabling subtitles for localized sounds.</summary>
	public bool bSubtitlesEnabled;
	///<summary>Flag for forcibly disabling subtitles even if you try to turn them back on they will be off</summary>
	public bool bSubtitlesForcedOff;
	///<summary>Script maximum loop iteration count used as a threshold to warn users about script execution runaway</summary>
	public int MaximumLoopIterationCount;
	///<summary>Controls whether Blueprint subclasses of actors or components can tick by default.</summary>
	public bool bCanBlueprintsTickByDefault;
	///<summary>Controls whether anim blueprint nodes that access member variables of their class directly should use the optimized path that avoids a thunk to the Blueprint VM. This will force all anim blueprints to be recompiled.</summary>
	public bool bOptimizeAnimBlueprintMemberVariableAccess;
	///<summary>Controls whether by default we allow anim blueprint graph updates to be performed on non-game threads. This enables some extra checks in the anim blueprint compiler that will warn when unsafe operations are being attempted. This will force all anim blueprints to be recompiled.</summary>
	public bool bAllowMultiThreadedAnimationUpdate;
	///<summary>Controls whether cascade particle system LODs are updated in real time, or use the set value</summary>
	public bool bEnableEditorPSysRealtimeLOD;
	///<summary>Whether to enable framerate smoothing.</summary>
	public bool bSmoothFrameRate;
	///<summary>Whether to use a fixed framerate.</summary>
	public bool bUseFixedFrameRate;
	///<summary>The fixed framerate to use.</summary>
	public float FixedFrameRate;
	///<summary>Range of framerates in which smoothing will kick in</summary>
	public FFloatRange SmoothedFrameRateRange;
	///<summary>Controls how the Engine process the Framerate/Timestep</summary>
	public UEngineCustomTimeStep CustomTimeStep;
	///<summary>Override how the Engine process the Framerate/Timestep.</summary>
	public FSoftClassPath CustomTimeStepClassName;
	///<summary>Controls the Engine&#39;s timecode.</summary>
	public UTimecodeProvider TimecodeProvider;
	///<summary>Set TimecodeProvider when the engine is started.</summary>
	public FSoftClassPath TimecodeProviderClassName;
	///<summary>Generate a default timecode from the computer clock when there is no timecode provider.</summary>
	public bool bGenerateDefaultTimecode;
	///<summary>When generating a default timecode (bGenerateDefaultTimecode is true and no timecode provider is set) at which frame rate it should be generated (number of frames).</summary>
	public FFrameRate GenerateDefaultTimecodeFrameRate;
	///<summary>Number of frames to subtract from generated default timecode.</summary>
	public float GenerateDefaultTimecodeFrameDelay;
	///<summary>Whether we should check for more than N pawns spawning in a single frame.</summary>
	public bool bCheckForMultiplePawnsSpawnedInAFrame;
	///<summary>If bCheckForMultiplePawnsSpawnedInAFrame==true, then we will check to see that no more than this number of pawns are spawned in a frame. *</summary>
	public int NumPawnsAllowedToBeSpawnedInAFrame;
	///<summary>Whether or not the LQ lightmaps should be generated during lighting rebuilds.  This has been moved to r.SupportLowQualityLightmaps.</summary>
	public bool bShouldGenerateLowQualityLightmaps_DEPRECATED;
	///<summary>Various Colors used for editor and debug rendering</summary>
	public FColor C_WorldBox;
	///<summary>C_BrushWire</summary>
	public FColor C_BrushWire;
	///<summary>C_AddWire</summary>
	public FColor C_AddWire;
	///<summary>C_SubtractWire</summary>
	public FColor C_SubtractWire;
	///<summary>C_SemiSolidWire</summary>
	public FColor C_SemiSolidWire;
	///<summary>C_NonSolidWire</summary>
	public FColor C_NonSolidWire;
	///<summary>C_WireBackground</summary>
	public FColor C_WireBackground;
	///<summary>C_ScaleBoxHi</summary>
	public FColor C_ScaleBoxHi;
	///<summary>C_VolumeCollision</summary>
	public FColor C_VolumeCollision;
	///<summary>C_BSPCollision</summary>
	public FColor C_BSPCollision;
	///<summary>C_OrthoBackground</summary>
	public FColor C_OrthoBackground;
	///<summary>C_Volume</summary>
	public FColor C_Volume;
	///<summary>C_BrushShape</summary>
	public FColor C_BrushShape;
	///<summary>The save directory for newly created screenshots</summary>
	public FDirectoryPath GameScreenshotSaveDirectory;
	///<summary>UseStaticMeshMinLODPerQualityLevels</summary>
	public bool UseStaticMeshMinLODPerQualityLevels;
	///<summary>UseSkeletalMeshMinLODPerQualityLevels</summary>
	public bool UseSkeletalMeshMinLODPerQualityLevels;
	///<summary>UseGrassVarityPerQualityLevels</summary>
	public bool UseGrassVarityPerQualityLevels;
	///<summary>The state of the current map transition.</summary>
	public ETransitionType TransitionType;
	///<summary>The current transition description text.</summary>
	public string TransitionDescription;
	///<summary>The gamemode for the destination map</summary>
	public string TransitionGameMode;
	///<summary>Whether to play mature language sound nodes</summary>
	public bool bAllowMatureLanguage;
	///<summary>camera rotation (deg) beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
	public float CameraRotationThreshold;
	///<summary>camera movement beyond which occlusion queries are ignored from previous frame (because they are likely not valid)</summary>
	public float CameraTranslationThreshold;
	///<summary>The amount of time a primitive is considered to be probably visible after it was last actually visible.</summary>
	public float PrimitiveProbablyVisibleTime;
	///<summary>Max screen pixel fraction where retesting when unoccluded is worth the GPU time.</summary>
	public float MaxOcclusionPixelsFraction;
	///<summary>Whether to pause the game if focus is lost.</summary>
	public bool bPauseOnLossOfFocus;
	///<summary>The maximum allowed size to a ParticleEmitterInstance::Resize call.</summary>
	public int MaxParticleResize;
	///<summary>If the resize request is larger than this, spew out a warning to the log</summary>
	public int MaxParticleResizeWarn;
	///<summary>List of notes to place during Play in Editor</summary>
	public TArray<FDropNoteInfo> PendingDroppedNotes;
	///<summary>Number of times to tick each client per second</summary>
	public float NetClientTicksPerSecond;
	///<summary>Current display gamma setting</summary>
	public float DisplayGamma;
	///<summary>Minimum desired framerate setting, below this frame rate visual detail may be lowered</summary>
	public float MinDesiredFrameRate;
	///<summary>Default color of selected objects in the level viewport (additive)</summary>
	public FLinearColor DefaultSelectedMaterialColor;
	///<summary>Color of selected objects in the level viewport (additive)</summary>
	public FLinearColor SelectedMaterialColor;
	///<summary>Color of the selection outline color.  Generally the same as selected material color unless the selection material color is being overridden</summary>
	public FLinearColor SelectionOutlineColor;
	///<summary>Subdued version of the selection outline color. Used for indicating sub-selection of components vs actors</summary>
	public FLinearColor SubduedSelectionOutlineColor;
	///<summary>An override to use in some cases instead of the selected material color</summary>
	public FLinearColor SelectedMaterialColorOverride;
	///<summary>Whether or not selection color is being overridden</summary>
	public bool bIsOverridingSelectedColor;
	///<summary>If true, then disable OnScreenDebug messages. Can be toggled in real-time.</summary>
	public bool bEnableOnScreenDebugMessages;
	///<summary>If true, then disable the display of OnScreenDebug messages (used when running)</summary>
	public bool bEnableOnScreenDebugMessagesDisplay;
	///<summary>If true, then skip drawing map warnings on screen even in non (UE_BUILD_SHIPPING || UE_BUILD_TEST) builds</summary>
	public bool bSuppressMapWarnings;
	///<summary>determines whether AI logging should be processed or not</summary>
	public bool bDisableAILogging;
	///<summary>If true, the visual logger will start recording as soon as the engine starts</summary>
	public uint bEnableVisualLogRecordingOnStart;
	///<summary>Semaphore to control screen saver inhibitor thread access.</summary>
	public int ScreenSaverInhibitorSemaphore;
	///<summary>true if the the user cannot modify levels that are read only.</summary>
	public bool bLockReadOnlyLevels;
	///<summary>Sets the class to use to spawn a ParticleEventManager that can handle game-specific particle system behavior</summary>
	public string ParticleEventManagerClassPath;
	///<summary>Used to alter the intensity level of the selection highlight on selected objects</summary>
	public float SelectionHighlightIntensity;
	///<summary>Used to alter the intensity level of the selection highlight on selected BSP surfaces</summary>
	public float BSPSelectionHighlightIntensity;
	///<summary>Used to alter the intensity level of the selection highlight on selected billboard objects</summary>
	public float SelectionHighlightIntensityBillboards;
	///<summary>Increments every time a non-seamless travel happens on a server, to generate net session id&#39;s. Written to config to preserve id upon crash.</summary>
	public uint GlobalNetTravelCount;
	///<summary>A list of named UNetDriver definitions</summary>
	public TArray<FNetDriverDefinition> NetDriverDefinitions;
	///<summary>A list of Iris NetDriverConfigs</summary>
	public TArray<FIrisNetDriverConfig> IrisNetDriverConfigs;
	///<summary>A configurable list of actors that are automatically spawned upon server startup (just prior to InitGame)</summary>
	public TArray<string> ServerActors;
	///<summary>Runtime-modified list of server actors, allowing plugins to use serveractors, without permanently adding them to config files</summary>
	public TArray<string> RuntimeServerActors;
	///<summary>Amount of time in seconds between network error logging</summary>
	public float NetErrorLogInterval;
	///<summary>true if the loading movie was started during LoadMap().</summary>
	public bool bStartedLoadMapMovie;
	///<summary>NextWorldContextHandle</summary>
	public int NextWorldContextHandle;
}

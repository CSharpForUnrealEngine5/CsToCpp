namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements Editor settings for experimental features.</summary>
[CppInclude("Settings/EditorExperimentalSettings.h")]
public partial class UEditorExperimentalSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Enable async texture compilation to improve PIE and map load time performance when compilation is required</summary>
	public bool bEnableAsyncTextureCompilation;
	///<summary>Enable async static mesh compilation to improve import and map load time performance when compilation is required</summary>
	public bool bEnableAsyncStaticMeshCompilation;
	///<summary>, Category = Performance, meta = (DisplayName = &quot;Enable async skeletal mesh compilation and loading&quot;)</summary>
	public bool bEnableAsyncSkeletalMeshCompilation;
	///<summary>Enable async skinned asset compilation to improve import and map load time performance when compilation is required</summary>
	public bool bEnableAsyncSkinnedAssetCompilation;
	///<summary>Enable async sound compilation to improve import and map load time performance when compilation is required</summary>
	public bool bEnableAsyncSoundWaveCompilation;
	///<summary>Allows the editor to run on HDR monitors on Windows 10</summary>
	public bool bHDREditor;
	///<summary>The brightness of the slate UI on HDR monitors</summary>
	public float HDREditorNITLevel;
	///<summary>Allows usage of the procedural foliage system</summary>
	public bool bProceduralFoliage;
	///<summary>Allows usage of the Translation Picker</summary>
	public bool bEnableTranslationPicker;
	///<summary>Specify which console-specific nomenclature to use for gamepad label text</summary>
	public EConsoleForGamepadLabels ConsoleForGamepadLabels;
	///<summary>Allows for customization of toolbars and menus throughout the editor</summary>
	public bool bToolbarCustomization;
	///<summary>Break on Exceptions allows you to trap Access Nones and other exceptional events in Blueprints.</summary>
	public bool bBreakOnExceptions;
	///<summary>, Category=Blueprints, meta=(DisplayName=&quot;Draw midpoint arrows in Blueprints&quot;)</summary>
	public bool bDrawMidpointArrowsInBlueprints;
	///<summary>Allows ChunkIDs to be assigned to assets to via the content browser context menu.</summary>
	public bool bContextMenuChunkAssignments;
	///<summary>Disable cook in the editor</summary>
	public bool bDisableCookInEditor;
	///<summary>bSharedCookedBuilds</summary>
	public bool bSharedCookedBuilds;
	///<summary>MultiProcessCooking_DEPRECATED</summary>
	public int MultiProcessCooking_DEPRECATED;
	///<summary>Enable late joining in PIE</summary>
	public bool bAllowLateJoinInPIE;
	///<summary>Allow Vulkan Preview</summary>
	public bool bAllowVulkanPreview;
	///<summary>Enable multithreaded lightmap encoding (decreases time taken to encode lightmaps)</summary>
	public bool bEnableMultithreadedLightmapEncoding;
	///<summary>Enable multithreaded shadow map encoding (decreases time taken to encode shadow maps)</summary>
	public bool bEnableMultithreadedShadowmapEncoding;
	///<summary>Whether to use OpenCL to accelerate convex hull decomposition (uses GPU to decrease time taken to decompose meshes, currently only available on Mac OS X)</summary>
	public bool bUseOpenCLForConvexHullDecomp;
	///<summary>Allows editing of potentially unsafe properties during PIE. Advanced use only - use with caution.</summary>
	public bool bAllowPotentiallyUnsafePropertyEditing;
	///<summary>Enable experimental bulk facial animation importer (found in Developer Tools menu, requires editor restart)</summary>
	public bool bFacialAnimationImporter;
	///<summary>Enable experimental PIE preview device launch</summary>
	public bool bMobilePIEPreviewDeviceLaunch;
	///<summary>Enables in-editor support for text asset formats</summary>
	public bool bTextAssetFormatSupport;
	///<summary>Enables in-editor support for rehydrating virtualized assets</summary>
	public bool bVirtualizedAssetRehydration;
	///<summary>When creating new Material Layers and Material Layer Blends, set up example graphs.</summary>
	public bool bExampleLayersAndBlends;
	///<summary>Allows creation of assets with paths longer than 260 characters. Note that this also requires the Windows 10 Anniversary Update (1607), and support for long paths to be enabled through the group policy editor.</summary>
	public bool bEnableLongPathsSupport;
	///<summary>Allows creating APackedLevelActor blueprint actors</summary>
	public bool bPackedLevelActor;
	///<summary>Allows creating ALevelInstance actors</summary>
	public bool bLevelInstance;
}

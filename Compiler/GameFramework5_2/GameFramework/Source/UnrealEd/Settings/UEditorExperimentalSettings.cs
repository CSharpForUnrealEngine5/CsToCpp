#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorExperimentalSettings.h")]
///<summary>Implements Editor settings for experimental features.</summary>
public partial class UEditorExperimentalSettings : UObject {
// EditorExperimentalSettings
	public bool bEnableAsyncTextureCompilation;
	public bool bEnableAsyncStaticMeshCompilation;
	public bool bEnableAsyncSkeletalMeshCompilation;
	public bool bEnableAsyncSkinnedAssetCompilation;
	public bool bEnableAsyncSoundWaveCompilation;
	public bool bHDREditor;
	public float HDREditorNITLevel;
	public bool bProceduralFoliage;
	public bool bEnableTranslationPicker;
	public EConsoleForGamepadLabels ConsoleForGamepadLabels;
	public bool bToolbarCustomization;
	public bool bBreakOnExceptions;
	public bool bDrawMidpointArrowsInBlueprints;
	public bool bContextMenuChunkAssignments;
	public bool bDisableCookInEditor;
	public bool bSharedCookedBuilds;
	public int MultiProcessCooking_DEPRECATED;
	public bool bAllowLateJoinInPIE;
	public bool bAllowVulkanPreview;
	public bool bEnableMultithreadedLightmapEncoding;
	public bool bEnableMultithreadedShadowmapEncoding;
	public bool bUseOpenCLForConvexHullDecomp;
	public bool bAllowPotentiallyUnsafePropertyEditing;
	public bool bFacialAnimationImporter;
	public bool bMobilePIEPreviewDeviceLaunch;
	public bool bTextAssetFormatSupport;
	public bool bVirtualizedAssetRehydration;
	public bool bExampleLayersAndBlends;
	public bool bEnableLongPathsSupport;
	public bool bPackedLevelActor;
	public bool bLevelInstance;
}

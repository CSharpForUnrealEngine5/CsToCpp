#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/PersonaOptions.h")]
public partial class UPersonaOptions : UObject {
// PersonaOptions
	public bool bAutoAlignFloorToMesh;
	public bool bAlwaysOpenAnimationAssetsInNewTab;
	public bool bShowGrid;
	public bool bHighlightOrigin;
	public bool bMuteAudio;
	public bool bUseAudioAttenuation;
	public int ShowMeshStats;
	public uint DefaultLocalAxesSelection;
	public uint DefaultBoneDrawSelection;
	public FLinearColor DefaultBoneColor;
	public FLinearColor SelectedBoneColor;
	public FLinearColor AffectedBoneColor;
	public FLinearColor DisabledBoneColor;
	public FLinearColor ParentOfSelectedBoneColor;
	public FLinearColor VirtualBoneColor;
	public FLinearColor SectionTimingNodeColor;
	public FLinearColor NotifyTimingNodeColor;
	public FLinearColor BranchingPointTimingNodeColor;
	public bool bPauseAnimationOnCameraMove;
	public bool bUseInlineSocketEditor;
	public bool bFlattenSkeletonHierarchyWhenFiltering;
	public bool bHideParentsWhenFiltering;
	public bool bExpandTreeOnSelection;
	public bool bAllowPreviewMeshCollectionsToSelectFromDifferentSkeletons;
	public bool bAllowPreviewMeshCollectionsToUseCustomAnimBP;
	public bool bAllowMeshSectionSelection;
	public uint NumFolderFiltersInAssetBrowser;
	public TArray<FAssetEditorOptions> AssetEditorOptions;
	public float CurveEditorSnapInterval;
	public int TimelineScrubSnapValue;
	public EFrameNumberDisplayFormats TimelineDisplayFormat;
	public bool bTimelineDisplayPercentage;
	public bool bTimelineDisplayFormatSecondary;
	public bool bTimelineDisplayCurveKeys;
	public TArray<string> TimelineEnabledSnaps;
	public bool bAllowIncompatibleSkeletonSelection;
	public bool bUseTreeViewForAnimationCurves;
	public string AnimationCurveGroupingDelimiters;
}

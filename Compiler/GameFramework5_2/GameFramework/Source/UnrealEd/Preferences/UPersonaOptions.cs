namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/PersonaOptions.h")]
public partial class UPersonaOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not the floor should be aligned to the Skeletal Mesh&#39;s bounds by default for the Animation Editor(s)</summary>
	public bool bAutoAlignFloorToMesh;
	///<summary>Whether or not the Animation Editor opens in an additional tab when double clicking an animation asset or if it reuses an already existing Animation Editor tab.</summary>
	public bool bAlwaysOpenAnimationAssetsInNewTab;
	///<summary>Whether or not the grid should be visible by default for the Animation Editor(s)</summary>
	public bool bShowGrid;
	///<summary>Whether or not the XYZ axis at the origin should be highlighted on the grid by default</summary>
	public bool bHighlightOrigin;
	///<summary>Whether or not audio should be muted by default for the Animation Editor(s)</summary>
	public bool bMuteAudio;
	///<summary>bUseAudioAttenuation</summary>
	public bool bUseAudioAttenuation;
	///<summary>Currently Stats can have None, Basic and Detailed. Please refer to EDisplayInfoMode.</summary>
	public int ShowMeshStats;
	///<summary>Index used to determine which ViewMode should be used by default for the Animation Editor(s)</summary>
	public uint DefaultLocalAxesSelection;
	///<summary>Index used to determine which Bone Draw Mode should be used by default for the Animation Editor(s)</summary>
	public uint DefaultBoneDrawSelection;
	///<summary>DefaultBoneColor</summary>
	public FLinearColor DefaultBoneColor;
	///<summary>SelectedBoneColor</summary>
	public FLinearColor SelectedBoneColor;
	///<summary>AffectedBoneColor</summary>
	public FLinearColor AffectedBoneColor;
	///<summary>DisabledBoneColor</summary>
	public FLinearColor DisabledBoneColor;
	///<summary>ParentOfSelectedBoneColor</summary>
	public FLinearColor ParentOfSelectedBoneColor;
	///<summary>VirtualBoneColor</summary>
	public FLinearColor VirtualBoneColor;
	///<summary>SectionTimingNodeColor</summary>
	public FLinearColor SectionTimingNodeColor;
	///<summary>NotifyTimingNodeColor</summary>
	public FLinearColor NotifyTimingNodeColor;
	///<summary>BranchingPointTimingNodeColor</summary>
	public FLinearColor BranchingPointTimingNodeColor;
	///<summary>Pause the preview animation if playing when moving the camera and resume when finished</summary>
	public bool bPauseAnimationOnCameraMove;
	///<summary>Whether to use a socket editor that is created in-line inside the skeleton tree, or whether to use the separate details panel</summary>
	public bool bUseInlineSocketEditor;
	///<summary>Whether to keep the hierarchy or flatten it when searching for bones, sockets etc.</summary>
	public bool bFlattenSkeletonHierarchyWhenFiltering;
	///<summary>Whether to hide parent items when filtering or to display them grayed out</summary>
	public bool bHideParentsWhenFiltering;
	///<summary>Whether to focus and expand an item&#39;s tree recursively based on selection</summary>
	public bool bExpandTreeOnSelection;
	///<summary>bAllowPreviewMeshCollectionsToSelectFromDifferentSkeletons</summary>
	public bool bAllowPreviewMeshCollectionsToSelectFromDifferentSkeletons;
	///<summary>bAllowPreviewMeshCollectionsToUseCustomAnimBP</summary>
	public bool bAllowPreviewMeshCollectionsToUseCustomAnimBP;
	///<summary>Whether or not Skeletal Mesh Section selection should be enabled by default for the Animation Editor(s)</summary>
	public bool bAllowMeshSectionSelection;
	///<summary>The number of folder filters to allow at any one time in the animation tool&#39;s asset browser</summary>
	public uint NumFolderFiltersInAssetBrowser;
	///<summary>Options that should be unique per asset editor (like skeletal mesh or anim sequence editors)</summary>
	public TArray<FAssetEditorOptions> AssetEditorOptions;
	///<summary>Snap value used to determine scrub resolution of the curve timeline</summary>
	public float CurveEditorSnapInterval;
	///<summary>Snap value used to determine scrub resolution of the anim timeline</summary>
	public int TimelineScrubSnapValue;
	///<summary>Display format for the anim timeline</summary>
	public EFrameNumberDisplayFormats TimelineDisplayFormat;
	///<summary>Whether to display percentage in the anim timeline</summary>
	public bool bTimelineDisplayPercentage;
	///<summary>Whether to display secondary format (times/frames) in the anim timeline</summary>
	public bool bTimelineDisplayFormatSecondary;
	///<summary>Whether to display keys in the timeline&#39;s curve tracks</summary>
	public bool bTimelineDisplayCurveKeys;
	///<summary>Whether to snap to various things</summary>
	public TArray<string> TimelineEnabledSnaps;
	///<summary>Whether to allow animation assets that are incompatible with the current skeleton/skeletal mesh to be selected.</summary>
	public bool bAllowIncompatibleSkeletonSelection;
	///<summary>Whether to use tree view for animation curves</summary>
	public bool bUseTreeViewForAnimationCurves;
	///<summary>Delimiters to split animation curve names for grouping</summary>
	public string AnimationCurveGroupingDelimiters;
}

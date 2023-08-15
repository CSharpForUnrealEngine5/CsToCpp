namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Any property you&#39;re adding to AnimMontage and parent class has to be considered for Child Asset</summary>
[CppInclude("Animation/AnimMontage.h")]
public partial class UAnimMontage : UAnimCompositeBase {
	public static UClass StaticClass() {return default;}
	///<summary>BlendModeIn</summary>
	public EMontageBlendMode BlendModeIn;
	///<summary>BlendModeOut</summary>
	public EMontageBlendMode BlendModeOut;
	///<summary>Blend in option.</summary>
	public FAlphaBlend BlendIn;
	///<summary>BlendInTime_DEPRECATED</summary>
	public float BlendInTime_DEPRECATED;
	///<summary>Blend out option. This is only used when it blends out itself. If it&#39;s interrupted by other montages, it will use new montage&#39;s BlendIn option to blend out.</summary>
	public FAlphaBlend BlendOut;
	///<summary>BlendOutTime_DEPRECATED</summary>
	public float BlendOutTime_DEPRECATED;
	///<summary>Time from Sequence End to trigger blend out.</summary>
	public float BlendOutTriggerTime;
	///<summary>GetBlendInArgs</summary>
	public FAlphaBlendArgs GetBlendInArgs() { return default; }
	///<summary>GetBlendOutArgs</summary>
	public FAlphaBlendArgs GetBlendOutArgs() { return default; }
	///<summary>GetDefaultBlendInTime</summary>
	public float GetDefaultBlendInTime() { return default; }
	///<summary>GetDefaultBlendOutTime</summary>
	public float GetDefaultBlendOutTime() { return default; }
	///<summary>If you&#39;re using marker based sync for this montage, make sure to add sync group name. For now we only support one group</summary>
	public FName SyncGroup;
	///<summary>wip: until we have UI working</summary>
	public int SyncSlotIndex;
	///<summary>MarkerData</summary>
	public FMarkerSyncData MarkerData;
	///<summary>composite section.</summary>
	public TArray<FCompositeSection> CompositeSections;
	///<summary>slot data, each slot contains anim track</summary>
	public TArray<FSlotAnimationTrack> SlotAnimTracks;
	///<summary>Remove this when VER_UE4_MONTAGE_BRANCHING_POINT_REMOVAL is removed.</summary>
	public TArray<FBranchingPoint> BranchingPoints_DEPRECATED;
	///<summary>If this is on, it will allow extracting root motion translation. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
	public bool bEnableRootMotionTranslation;
	///<summary>If this is on, it will allow extracting root motion rotation. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
	public bool bEnableRootMotionRotation;
	///<summary>When it hits end, it automatically blends out. If this is false, it won&#39;t blend out but keep the last pose until stopped explicitly</summary>
	public bool bEnableAutoBlendOut;
	///<summary>The blend profile to use.</summary>
	public UBlendProfile BlendProfileIn;
	///<summary>The blend profile to use.</summary>
	public UBlendProfile BlendProfileOut;
	///<summary>Root Bone will be locked to that position when extracting root motion. DEPRECATED in 4.5 root motion is controlled by anim sequences *</summary>
	public ERootMotionRootLock RootMotionRootLock;
	///<summary>Preview Base pose for additive BlendSpace *</summary>
	public UAnimSequence PreviewBasePose;
	///<summary>Get SectionIndex from SectionName. Returns INDEX_None if not found</summary>
	public int GetSectionIndex(FName InSectionName) { return default; }
	///<summary>Get SectionName from SectionIndex. Returns NAME_None if not found</summary>
	public FName GetSectionName(int SectionIndex) { return default; }
	///<summary>Returns the number of sections this montage has</summary>
	public int GetNumSections() { return default; }
	///<summary>@return true if valid section</summary>
	public bool IsValidSectionName(FName InSectionName) { return default; }
	///<summary>Cached list of Branching Point markers</summary>
	public TArray<FBranchingPointMarker> BranchingPointMarkers;
	///<summary>Keep track of which AnimNotify_State are marked as BranchingPoints, so we can update their state when the Montage is ticked</summary>
	public TArray<int> BranchingPointStateNotifyIndices;
	///<summary>Utility function to create dynamic montage from AnimSequence with blend in settings</summary>
	public static UAnimMontage CreateSlotAnimationAsDynamicMontage_WithBlendSettings(UAnimSequenceBase Asset,FName SlotNodeName,FMontageBlendSettings BlendInSettings,FMontageBlendSettings BlendOutSettings,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float InBlendOutTriggerTime/*=-1.0f*/) { return default; }
	///<summary>Time stretch curve will only be used when the montage has a non-default play rate</summary>
	public FTimeStretchCurve TimeStretchCurve;
	///<summary>Name of optional TimeStretchCurveName to look for in Montage. Time stretch curve will only be used when the montage has a non-default play rate</summary>
	public FName TimeStretchCurveName;
}

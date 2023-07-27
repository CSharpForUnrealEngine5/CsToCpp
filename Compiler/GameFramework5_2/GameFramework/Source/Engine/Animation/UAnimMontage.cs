#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimMontage.h")]
///<summary>Any property you're adding to AnimMontage and parent class has to be considered for Child Asset</summary>
public partial class UAnimMontage : UAnimCompositeBase {
// AnimMontage
	public EMontageBlendMode BlendModeIn;
	public EMontageBlendMode BlendModeOut;
	public FAlphaBlend BlendIn;
	public float BlendInTime_DEPRECATED;
	public FAlphaBlend BlendOut;
	public float BlendOutTime_DEPRECATED;
	public float BlendOutTriggerTime;
	public  FAlphaBlendArgs GetBlendInArgs() { return default; }
	public  FAlphaBlendArgs GetBlendOutArgs() { return default; }
	public  float GetDefaultBlendInTime() { return default; }
	public  float GetDefaultBlendOutTime() { return default; }
	public string SyncGroup;
	public int SyncSlotIndex;
	public FMarkerSyncData MarkerData;
	public TArray<FCompositeSection> CompositeSections;
	public TArray<FSlotAnimationTrack> SlotAnimTracks;
	public TArray<FBranchingPoint> BranchingPoints_DEPRECATED;
	public bool bEnableRootMotionTranslation;
	public bool bEnableRootMotionRotation;
	public bool bEnableAutoBlendOut;
	public UBlendProfile BlendProfileIn;
	public UBlendProfile BlendProfileOut;
	public ERootMotionRootLock RootMotionRootLock;
	public UAnimSequence PreviewBasePose;
	public  int GetSectionIndex(string InSectionName) { return default; }
	public  string GetSectionName(int SectionIndex) { return default; }
	public  int GetNumSections() { return default; }
	public  bool IsValidSectionName(string InSectionName) { return default; }
	public TArray<FBranchingPointMarker> BranchingPointMarkers;
	public TArray<int> BranchingPointStateNotifyIndices;
	public static UAnimMontage CreateSlotAnimationAsDynamicMontage_WithBlendSettings(UAnimSequenceBase Asset,string SlotNodeName,FMontageBlendSettings BlendInSettings,FMontageBlendSettings BlendOutSettings,float InPlayRate/*=1.0f*/,int LoopCount/*=1*/,float InBlendOutTriggerTime/*=-1.0f*/) { return default; }
	public FTimeStretchCurve TimeStretchCurve;
	public string TimeStretchCurveName;
}

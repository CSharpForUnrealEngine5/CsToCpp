#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RetargetEditor/IKRetargeterController.h")]
///<summary>A stateless singleton (1-per-asset) class used to make modifications to a UIKRetargeter asset.</summary>
public partial class UIKRetargeterController : UObject {
// IKRetargeterController
	public UObject GetController(UObject InRetargeterAsset) { return default; }
	public void SetIKRig(ERetargetSourceOrTarget SourceOrTarget,UObject IKRig) {}
	public UObject GetIKRig(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public void SetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget,UObject InPreviewMesh) {}
	public UObject GetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public FTargetRootSettings GetRootSettings() { return default; }
	public void SetRootSettings(FTargetRootSettings RootSettings) {}
	public FRetargetGlobalSettings GetGlobalSettings() { return default; }
	public void SetGlobalSettings(FRetargetGlobalSettings GlobalSettings) {}
	public FTargetChainSettings GetRetargetChainSettings(string TargetChainName) { return default; }
	public bool SetRetargetChainSettings(string TargetChainName,FTargetChainSettings Settings) { return default; }
	public void AutoMapChains(EAutoMapChainType AutoMapType,bool bForceRemap) {}
	public bool SetSourceChain(string SourceChainName,string TargetChainName) { return default; }
	public string GetSourceChain(string TargetChainName) { return default; }
	public TArray<UObject> GetAllChainSettings() { return default; }
	public string CreateRetargetPose(string NewPoseName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public bool RemoveRetargetPose(string PoseToRemove,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public string DuplicateRetargetPose(string PoseToDuplicate,string NewName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public bool RenameRetargetPose(string OldPoseName,string NewPoseName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public bool SetCurrentRetargetPose(string CurrentPose,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public string GetCurrentRetargetPoseName(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public TMap<string,FIKRetargetPose> GetRetargetPoses(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public FIKRetargetPose GetCurrentRetargetPose(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public void ResetRetargetPose(string PoseToReset,TArray<string> BonesToReset,ERetargetSourceOrTarget SourceOrTarget) {}
	public void SetRotationOffsetForRetargetPoseBone(string BoneName,FQuat RotationOffset,ERetargetSourceOrTarget SkeletonMode) {}
	public FQuat GetRotationOffsetForRetargetPoseBone(string BoneName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	public void SetRootOffsetInRetargetPose(FVector TranslationOffset,ERetargetSourceOrTarget SourceOrTarget) {}
	public FVector GetRootOffsetInRetargetPose(ERetargetSourceOrTarget SourceOrTarget) { return default; }
}

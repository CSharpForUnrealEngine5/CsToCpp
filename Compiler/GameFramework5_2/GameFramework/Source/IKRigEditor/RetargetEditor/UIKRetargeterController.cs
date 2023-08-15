namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A stateless singleton (1-per-asset) class used to make modifications to a UIKRetargeter asset.</summary>
[CppInclude("RetargetEditor/IKRetargeterController.h")]
public partial class UIKRetargeterController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Use this to get the controller for the given retargeter asset</summary>
	public static UIKRetargeterController GetController(UIKRetargeter InRetargeterAsset) { return default; }
	///<summary>Set the IK Rig to use as the source or target (to copy animation FROM/TO)</summary>
	public void SetIKRig(ERetargetSourceOrTarget SourceOrTarget,UIKRigDefinition IKRig) {}
	///<summary>Get either source or target IK Rig</summary>
	public UIKRigDefinition GetIKRig(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Set the preview skeletal mesh for either source or target</summary>
	public void SetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget,USkeletalMesh InPreviewMesh) {}
	///<summary>Get the preview skeletal mesh</summary>
	public USkeletalMesh GetPreviewMesh(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Get a copy of the retarget root settings for this asset.</summary>
	public FTargetRootSettings GetRootSettings() { return default; }
	///<summary>Set the retarget root settings for this asset.</summary>
	public void SetRootSettings(FTargetRootSettings RootSettings) {}
	///<summary>Get a copy of the global settings for this asset.</summary>
	public FRetargetGlobalSettings GetGlobalSettings() { return default; }
	///<summary>Get a copy of the global settings for this asset.</summary>
	public void SetGlobalSettings(FRetargetGlobalSettings GlobalSettings) {}
	///<summary>Get a copy of the settings for the target chain by name.</summary>
	public FTargetChainSettings GetRetargetChainSettings(FName TargetChainName) { return default; }
	///<summary>Set the settings for the target chain by name. Returns true if the chain settings were applied, false otherwise.</summary>
	public bool SetRetargetChainSettings(FName TargetChainName,FTargetChainSettings Settings) { return default; }
	///<summary>Use fuzzy string search to find &quot;best&quot; Source chain to map to each Target chain</summary>
	public void AutoMapChains(EAutoMapChainType AutoMapType,bool bForceRemap) {}
	///<summary>Assign a source chain to the given target chain. Animation will be copied from the source to the target.</summary>
	public bool SetSourceChain(FName SourceChainName,FName TargetChainName) { return default; }
	///<summary>Get the name of the source chain mapped to a given target chain (the chain animation is copied FROM).</summary>
	public FName GetSourceChain(FName TargetChainName) { return default; }
	///<summary>Get read-only access to the list of settings for each target chain</summary>
	public TArray<URetargetChainSettings> GetAllChainSettings() { return default; }
	///<summary>Add new retarget pose. Returns the name of the new retarget pose.</summary>
	public FName CreateRetargetPose(FName NewPoseName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Remove a retarget pose. Returns true if the pose was found and removed.</summary>
	public bool RemoveRetargetPose(FName PoseToRemove,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Duplicate a retarget pose. Returns the name of the new, duplicate pose (or NAME_None if PoseToDuplicate is not found).</summary>
	public FName DuplicateRetargetPose(FName PoseToDuplicate,FName NewName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Rename current retarget pose. Returns true if a pose was renamed.</summary>
	public bool RenameRetargetPose(FName OldPoseName,FName NewPoseName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Change which retarget pose is used by the retargeter at runtime</summary>
	public bool SetCurrentRetargetPose(FName CurrentPose,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Get the current retarget pose</summary>
	public FName GetCurrentRetargetPoseName(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Get access to array of retarget poses</summary>
	public TMap<FName,FIKRetargetPose> GetRetargetPoses(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Get the current retarget pose</summary>
	public FIKRetargetPose GetCurrentRetargetPose(ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Reset a retarget pose for the specified bones.</summary>
	public void ResetRetargetPose(FName PoseToReset,TArray<FName> BonesToReset,ERetargetSourceOrTarget SourceOrTarget) {}
	///<summary>Set a delta rotation for a given bone for the current retarget pose</summary>
	public void SetRotationOffsetForRetargetPoseBone(FName BoneName,FQuat RotationOffset,ERetargetSourceOrTarget SkeletonMode) {}
	///<summary>Get a delta rotation for a given bone for the current retarget pose</summary>
	public FQuat GetRotationOffsetForRetargetPoseBone(FName BoneName,ERetargetSourceOrTarget SourceOrTarget) { return default; }
	///<summary>Set the translation offset on the retarget root bone for the current retarget pose</summary>
	public void SetRootOffsetInRetargetPose(FVector TranslationOffset,ERetargetSourceOrTarget SourceOrTarget) {}
	///<summary>Get the translation offset on the retarget root bone for the current retarget pose</summary>
	public FVector GetRootOffsetInRetargetPose(ERetargetSourceOrTarget SourceOrTarget) { return default; }
}

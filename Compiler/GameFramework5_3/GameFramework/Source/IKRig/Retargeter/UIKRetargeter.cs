namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial class UIKRetargeter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Returns the chain settings associated with a given Goal in an IK Retargeter Asset using the given profile name (optional)</summary>
	public static FTargetChainSettings GetChainUsingGoalFromRetargetAsset(UIKRetargeter RetargetAsset,FName IKGoalName) { return default; }
	///<summary>Returns the chain settings associated with a given target chain in an IK Retargeter Asset using the given profile name (optional)</summary>
	public static FTargetChainSettings GetChainSettingsFromRetargetAsset(UIKRetargeter RetargetAsset,FName TargetChainName,FName OptionalProfileName) { return default; }
	///<summary>Returns the chain settings associated with a given target chain in the supplied Retarget Profile.</summary>
	public static FTargetChainSettings GetChainSettingsFromRetargetProfile(FRetargetProfile RetargetProfile,FName TargetChainName) { return default; }
	///<summary>Returns the root settings in an IK Retargeter Asset using the given profile name (optional)</summary>
	public static void GetRootSettingsFromRetargetAsset(UIKRetargeter RetargetAsset,FName OptionalProfileName,FTargetRootSettings OutSettings) {}
	///<summary>Returns the root settings in the supplied Retarget Profile.</summary>
	public static FTargetRootSettings GetRootSettingsFromRetargetProfile(FRetargetProfile RetargetProfile) { return default; }
	///<summary>Returns the global settings in an IK Retargeter Asset using the given profile name (optional)</summary>
	public static void GetGlobalSettingsFromRetargetAsset(UIKRetargeter RetargetAsset,FName OptionalProfileName,FRetargetGlobalSettings OutSettings) {}
	///<summary>Returns the global settings in the supplied Retarget Profile.</summary>
	public static FRetargetGlobalSettings GetGlobalSettingsFromRetargetProfile(FRetargetProfile RetargetProfile) { return default; }
	///<summary>Set the global settings in a retarget profile (will set bApplyGlobalSettings to true).</summary>
	public static void SetGlobalSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FRetargetGlobalSettings GlobalSettings) {}
	///<summary>Set the root settings in a retarget profile (will set bApplyRootSettings to true).</summary>
	public static void SetRootSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetRootSettings RootSettings) {}
	///<summary>Set the chain settings in a retarget profile (will set bApplyChainSettings to true).</summary>
	public static void SetChainSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainSettings ChainSettings,FName TargetChainName) {}
	///<summary>Set the chain FK settings in a retarget profile (will set bApplyChainSettings to true).</summary>
	public static void SetChainFKSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainFKSettings FKSettings,FName TargetChainName) {}
	///<summary>Set the chain IK settings in a retarget profile (will set bApplyChainSettings to true).</summary>
	public static void SetChainIKSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainIKSettings IKSettings,FName TargetChainName) {}
	///<summary>Set the chain Speed Plant settings in a retarget profile (will set bApplyChainSettings to true).</summary>
	public static void SetChainSpeedPlantSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainSpeedPlantSettings SpeedPlantSettings,FName TargetChainName) {}
	///<summary>The rig to copy animation FROM.</summary>
	public TSoftObjectPtr<UIKRigDefinition> SourceIKRigAsset;
	///<summary>Optional. Override the Skeletal Mesh to copy animation from. Uses the preview mesh from the Source IK Rig asset by default.</summary>
	public TSoftObjectPtr<USkeletalMesh> SourcePreviewMesh;
	///<summary>The rig to copy animation TO.</summary>
	public TSoftObjectPtr<UIKRigDefinition> TargetIKRigAsset;
	///<summary>Optional. Override the Skeletal Mesh to preview the retarget on. Uses the preview mesh from the Target IK Rig asset by default.</summary>
	public TSoftObjectPtr<USkeletalMesh> TargetPreviewMesh;
	///<summary>bRetargetRoot_DEPRECATED</summary>
	public bool bRetargetRoot_DEPRECATED;
	///<summary>bRetargetFK_DEPRECATED</summary>
	public bool bRetargetFK_DEPRECATED;
	///<summary>bRetargetIK_DEPRECATED</summary>
	public bool bRetargetIK_DEPRECATED;
	///<summary>TargetActorOffset_DEPRECATED</summary>
	public float TargetActorOffset_DEPRECATED;
	///<summary>TargetActorScale_DEPRECATED</summary>
	public float TargetActorScale_DEPRECATED;
	///<summary>The offset applied to the target mesh in the editor viewport.</summary>
	public FVector TargetMeshOffset;
	///<summary>Scale the target mesh in the viewport for easier visualization next to the source.</summary>
	public float TargetMeshScale;
	///<summary>The offset applied to the source mesh in the editor viewport.</summary>
	public FVector SourceMeshOffset;
	///<summary>Toggle debug drawing for retargeting in the viewport.</summary>
	public bool bDebugDraw;
	///<summary>Draw final IK goal locations.</summary>
	public bool bDrawFinalGoals;
	///<summary>Draw goal locations from source skeleton.</summary>
	public bool bDrawSourceLocations;
	///<summary>The visual size of the IK goals in the viewport.</summary>
	public float ChainDrawSize;
	///<summary>The thickness of lines on the IK goals in the viewport.</summary>
	public float ChainDrawThickness;
	///<summary>The visual size of the bones in the viewport (saved between sessions). This is set from the viewport Character&gt;Bones menu</summary>
	public float BoneDrawSize;
	///<summary>The controller responsible for managing this asset&#39;s data (all editor mutation goes through this)</summary>
	public UObject Controller;
	///<summary>only ask to fix the root height once, then warn thereafter (don&#39;t nag)</summary>
	public TSet<USkeletalMesh> MeshesAskedToFixRootHeightFor;
	///<summary>ChainMapping_DEPRECATED</summary>
	public TArray<FRetargetChainMap> ChainMapping_DEPRECATED;
	///<summary>Settings for how to map source chains to target chains.</summary>
	public TArray<URetargetChainSettings> ChainSettings;
	///<summary>the retarget root settings</summary>
	public URetargetRootSettings RootSettings;
	///<summary>the retarget root settings</summary>
	public UIKRetargetGlobalSettings GlobalSettings;
	///<summary>settings profiles stored in this asset</summary>
	public TMap<FName,FRetargetProfile> Profiles;
	///<summary>CurrentProfile</summary>
	public FName CurrentProfile;
	///<summary>The set of retarget poses for the SOURCE skeleton.</summary>
	public TMap<FName,FIKRetargetPose> SourceRetargetPoses;
	///<summary>The set of retarget poses for the TARGET skeleton.</summary>
	public TMap<FName,FIKRetargetPose> TargetRetargetPoses;
	///<summary>The current retarget pose to use for the SOURCE.</summary>
	public FName CurrentSourceRetargetPose;
	///<summary>The current retarget pose to use for the TARGET.</summary>
	public FName CurrentTargetRetargetPose;
	///<summary>RetargetPoses_DEPRECATED</summary>
	public TMap<FName,FIKRetargetPose> RetargetPoses_DEPRECATED;
	///<summary>CurrentRetargetPose_DEPRECATED</summary>
	public FName CurrentRetargetPose_DEPRECATED;
}

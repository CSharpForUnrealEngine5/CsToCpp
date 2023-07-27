#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargeter.h")]
public partial class UIKRetargeter : UObject {
// IKRetargeter
	public static FTargetChainSettings GetChainUsingGoalFromRetargetAsset(UIKRetargeter RetargetAsset,string IKGoalName) { return default; }
	public static FTargetChainSettings GetChainSettingsFromRetargetAsset(UIKRetargeter RetargetAsset,string TargetChainName,string OptionalProfileName) { return default; }
	public static FTargetChainSettings GetChainSettingsFromRetargetProfile(FRetargetProfile RetargetProfile,string TargetChainName) { return default; }
	public static void GetRootSettingsFromRetargetAsset(UIKRetargeter RetargetAsset,string OptionalProfileName,FTargetRootSettings OutSettings) {}
	public static FTargetRootSettings GetRootSettingsFromRetargetProfile(FRetargetProfile RetargetProfile) { return default; }
	public static void GetGlobalSettingsFromRetargetAsset(UIKRetargeter RetargetAsset,string OptionalProfileName,FRetargetGlobalSettings OutSettings) {}
	public static FRetargetGlobalSettings GetGlobalSettingsFromRetargetProfile(FRetargetProfile RetargetProfile) { return default; }
	public static void SetGlobalSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FRetargetGlobalSettings GlobalSettings) {}
	public static void SetRootSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetRootSettings RootSettings) {}
	public static void SetChainSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainSettings ChainSettings,string TargetChainName) {}
	public static void SetChainFKSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainFKSettings FKSettings,string TargetChainName) {}
	public static void SetChainIKSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainIKSettings IKSettings,string TargetChainName) {}
	public static void SetChainSpeedPlantSettingsInRetargetProfile(FRetargetProfile RetargetProfile,FTargetChainSpeedPlantSettings SpeedPlantSettings,string TargetChainName) {}
	public TSoftObjectPtr<UIKRigDefinition> SourceIKRigAsset;
	public TSoftObjectPtr<USkeletalMesh> SourcePreviewMesh;
	public TSoftObjectPtr<UIKRigDefinition> TargetIKRigAsset;
	public TSoftObjectPtr<USkeletalMesh> TargetPreviewMesh;
	public bool bRetargetRoot_DEPRECATED;
	public bool bRetargetFK_DEPRECATED;
	public bool bRetargetIK_DEPRECATED;
	public float TargetActorOffset_DEPRECATED;
	public float TargetActorScale_DEPRECATED;
	public FVector TargetMeshOffset;
	public float TargetMeshScale;
	public FVector SourceMeshOffset;
	public bool bDebugDraw;
	public bool bDrawFinalGoals;
	public bool bDrawSourceLocations;
	public float ChainDrawSize;
	public float ChainDrawThickness;
	public float BoneDrawSize;
	public UObject Controller;
	public TSet<USkeletalMesh> MeshesAskedToFixRootHeightFor;
	public TArray<FRetargetChainMap> ChainMapping_DEPRECATED;
	public TArray<URetargetChainSettings> ChainSettings;
	public URetargetRootSettings RootSettings;
	public UIKRetargetGlobalSettings GlobalSettings;
	public TMap<string,FRetargetProfile> Profiles;
	public string CurrentProfile;
	public TMap<string,FIKRetargetPose> SourceRetargetPoses;
	public TMap<string,FIKRetargetPose> TargetRetargetPoses;
	public string CurrentSourceRetargetPose;
	public string CurrentTargetRetargetPose;
	public TMap<string,FIKRetargetPose> RetargetPoses_DEPRECATED;
	public string CurrentRetargetPose_DEPRECATED;
}

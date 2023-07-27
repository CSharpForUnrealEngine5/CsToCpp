#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRInputDeviceFunctionLibrary.h")]
///<summary>* SteamVR Input Extended Functions</summary>
public partial class UDEPRECATED_USteamVRInputDeviceFunctionLibrary : UBlueprintFunctionLibrary {
// USteamVRInputDeviceFunctionLibrary
	public static void GetFingerCurlsAndSplays(EHand Hand,FSteamVRFingerCurls FingerCurls,FSteamVRFingerSplays FingerSplays,ESkeletalSummaryDataType SummaryDataType/*=ESkeletalSummaryDataType.VR_SummaryType_FromAnimation*/) {}
	public static void PlaySteamVR_HapticFeedback(ESteamVRHand Hand,float StartSecondsFromNow,float DurationSeconds/*=1.0f*/,float Frequency/*=1.0f*/,float Amplitude/*=0.5f*/) {}
	public static void GetCurlsAndSplaysState(bool LeftHandState,bool RightHandState) {}
	public static void GetSkeletalState(bool LeftHandState,bool RightHandState) {}
	public static void GetControllerFidelity(EControllerFidelity LeftControllerFidelity,EControllerFidelity RightControllerFidelity) {}
	public static void SetCurlsAndSplaysState(bool NewLeftHandState,bool NewRightHandState) {}
	public static void GetPoseSource(bool bUsingSkeletonPose) {}
	public static void SetPoseSource(bool bUseSkeletonPose) {}
	public static void GetSkeletalTransform(FSteamVRSkeletonTransform LeftHand,FSteamVRSkeletonTransform RightHand,bool bWithController/*=false*/) {}
	public static void GetLeftHandPoseData(FVector Position,FRotator Orientation,FVector AngularVelocity,FVector Velocity) {}
	public static void GetRightHandPoseData(FVector Position,FRotator Orientation,FVector AngularVelocity,FVector Velocity) {}
	public static void GetSteamVR_ActionArray(TArray<FSteamVRAction> SteamVRActions) {}
	public static void FindSteamVR_Action(string ActionName,bool bResult,FSteamVRAction FoundAction,FSteamVRActionSet FoundActionSet,string ActionSet/*=new FName("main")*/) {}
	public static void GetSteamVR_ActionSetArray(TArray<FSteamVRActionSet> SteamVRActionSets) {}
	public static bool GetSteamVR_OriginTrackedDeviceInfo(FSteamVRAction SteamVRAction,FSteamVRInputOriginInfo InputOriginInfo) { return default; }
	public static void FindSteamVR_OriginTrackedDeviceInfo(string ActionName,bool bResult,FSteamVRInputOriginInfo InputOriginInfo,string ActionSet/*=new FName("main")*/) {}
	public static void GetSteamVR_OriginLocalizedName(FSteamVRAction SteamVRAction,TArray<ESteamVRInputStringBits> LocalizedParts,string OriginLocalizedName) {}
	public static void ShowSteamVR_ActionOrigin(FSteamVRAction SteamVRAction,FSteamVRActionSet SteamVRActionSet) {}
	public static bool FindSteamVR_ActionOrigin(string ActionName,string ActionSet/*=new FName("main")*/) { return default; }
	public static bool GetSteamVR_HandPoseRelativeToNow(FVector Position,FRotator Orientation,ESteamVRHand Hand/*=ESteamVRHand.VR_Left*/,float PredictedSecondsFromNow/*=0.0f*/) { return default; }
	public static float GetSteamVR_GlobalPredictedSecondsFromNow() { return default; }
	public static float SetSteamVR_GlobalPredictedSecondsFromNow(float NewValue) { return default; }
	public static void ShowAllSteamVR_ActionOrigins() {}
	public static TArray<FSteamVRInputBindingInfo> GetSteamVR_InputBindingInfo(FSteamVRAction SteamVRActionHandle) { return default; }
	public static TArray<FSteamVRInputBindingInfo> FindSteamVR_InputBindingInfo(string ActionName,string ActionSet/*=new FName("main")*/) { return default; }
	public static bool ResetSeatedPosition() { return default; }
	public static float GetUserIPD() { return default; }
}

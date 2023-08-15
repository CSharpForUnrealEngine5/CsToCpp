namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* SteamVR Input Extended Functions</summary>
[CppInclude("SteamVRInputDeviceFunctionLibrary.h")]
public partial class UDEPRECATED_USteamVRInputDeviceFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>GetFingerCurlsAndSplays</summary>
	public static void GetFingerCurlsAndSplays(EHand Hand,FSteamVRFingerCurls FingerCurls,FSteamVRFingerSplays FingerSplays,ESkeletalSummaryDataType SummaryDataType/*=ESkeletalSummaryDataType.VR_SummaryType_FromAnimation*/) {}
	///<summary>PlaySteamVR_HapticFeedback</summary>
	public static void PlaySteamVR_HapticFeedback(ESteamVRHand Hand,float StartSecondsFromNow,float DurationSeconds/*=1.0f*/,float Frequency/*=1.0f*/,float Amplitude/*=0.5f*/) {}
	///<summary>GetCurlsAndSplaysState</summary>
	public static void GetCurlsAndSplaysState(bool LeftHandState,bool RightHandState) {}
	///<summary>GetSkeletalState</summary>
	public static void GetSkeletalState(bool LeftHandState,bool RightHandState) {}
	///<summary>GetControllerFidelity</summary>
	public static void GetControllerFidelity(EControllerFidelity LeftControllerFidelity,EControllerFidelity RightControllerFidelity) {}
	///<summary>SetCurlsAndSplaysState</summary>
	public static void SetCurlsAndSplaysState(bool NewLeftHandState,bool NewRightHandState) {}
	///<summary>GetPoseSource</summary>
	public static void GetPoseSource(bool bUsingSkeletonPose) {}
	///<summary>SetPoseSource</summary>
	public static void SetPoseSource(bool bUseSkeletonPose) {}
	///<summary>GetSkeletalTransform</summary>
	public static void GetSkeletalTransform(FSteamVRSkeletonTransform LeftHand,FSteamVRSkeletonTransform RightHand,bool bWithController/*=false*/) {}
	///<summary>GetLeftHandPoseData</summary>
	public static void GetLeftHandPoseData(FVector Position,FRotator Orientation,FVector AngularVelocity,FVector Velocity) {}
	///<summary>GetRightHandPoseData</summary>
	public static void GetRightHandPoseData(FVector Position,FRotator Orientation,FVector AngularVelocity,FVector Velocity) {}
	///<summary>GetSteamVR_ActionArray</summary>
	public static void GetSteamVR_ActionArray(TArray<FSteamVRAction> SteamVRActions) {}
	///<summary>FindSteamVR_Action</summary>
	public static void FindSteamVR_Action(FName ActionName,bool bResult,FSteamVRAction FoundAction,FSteamVRActionSet FoundActionSet,FName ActionSet/*=new FName("main")*/) {}
	///<summary>GetSteamVR_ActionSetArray</summary>
	public static void GetSteamVR_ActionSetArray(TArray<FSteamVRActionSet> SteamVRActionSets) {}
	///<summary>GetSteamVR_OriginTrackedDeviceInfo</summary>
	public static bool GetSteamVR_OriginTrackedDeviceInfo(FSteamVRAction SteamVRAction,FSteamVRInputOriginInfo InputOriginInfo) { return default; }
	///<summary>FindSteamVR_OriginTrackedDeviceInfo</summary>
	public static void FindSteamVR_OriginTrackedDeviceInfo(FName ActionName,bool bResult,FSteamVRInputOriginInfo InputOriginInfo,FName ActionSet/*=new FName("main")*/) {}
	///<summary>GetSteamVR_OriginLocalizedName</summary>
	public static void GetSteamVR_OriginLocalizedName(FSteamVRAction SteamVRAction,TArray<ESteamVRInputStringBits> LocalizedParts,string OriginLocalizedName) {}
	///<summary>ShowSteamVR_ActionOrigin</summary>
	public static void ShowSteamVR_ActionOrigin(FSteamVRAction SteamVRAction,FSteamVRActionSet SteamVRActionSet) {}
	///<summary>FindSteamVR_ActionOrigin</summary>
	public static bool FindSteamVR_ActionOrigin(FName ActionName,FName ActionSet/*=new FName("main")*/) { return default; }
	///<summary>GetSteamVR_HandPoseRelativeToNow</summary>
	public static bool GetSteamVR_HandPoseRelativeToNow(FVector Position,FRotator Orientation,ESteamVRHand Hand/*=ESteamVRHand.VR_Left*/,float PredictedSecondsFromNow/*=0.0f*/) { return default; }
	///<summary>GetSteamVR_GlobalPredictedSecondsFromNow</summary>
	public static float GetSteamVR_GlobalPredictedSecondsFromNow() { return default; }
	///<summary>SetSteamVR_GlobalPredictedSecondsFromNow</summary>
	public static float SetSteamVR_GlobalPredictedSecondsFromNow(float NewValue) { return default; }
	///<summary>ShowAllSteamVR_ActionOrigins</summary>
	public static void ShowAllSteamVR_ActionOrigins() {}
	///<summary>GetSteamVR_InputBindingInfo</summary>
	public static TArray<FSteamVRInputBindingInfo> GetSteamVR_InputBindingInfo(FSteamVRAction SteamVRActionHandle) { return default; }
	///<summary>FindSteamVR_InputBindingInfo</summary>
	public static TArray<FSteamVRInputBindingInfo> FindSteamVR_InputBindingInfo(FName ActionName,FName ActionSet/*=new FName("main")*/) { return default; }
	///<summary>ResetSeatedPosition</summary>
	public static bool ResetSeatedPosition() { return default; }
	///<summary>GetUserIPD</summary>
	public static float GetUserIPD() { return default; }
}

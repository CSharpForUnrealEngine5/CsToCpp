namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Retargetting information for the SteamVR skeleton to UE4 stock skeleton</summary>
[CppInclude("SteamVRInputDeviceFunctionLibrary.h")]
public partial struct FUE4RetargettingRefs {
	public bool bIsInitialized;
	public bool bIsRightHanded;
	public FVector KnuckleAverageMS_UE4;
	public FVector WristSideDirectionLS_UE4;
	public FVector WristForwardLS_UE4;
}

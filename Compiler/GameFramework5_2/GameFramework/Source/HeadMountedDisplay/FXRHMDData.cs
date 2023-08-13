namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayTypes.h")]
public partial struct FXRHMDData {
	public bool bValid;
	public string DeviceName;
	public FGuid ApplicationInstanceID;
	public ETrackingStatus TrackingStatus;
	public FVector Position;
	public FQuat Rotation;
}

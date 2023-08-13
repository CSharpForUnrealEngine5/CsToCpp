namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayTypes.h")]
public partial struct FXRMotionControllerData {
	public bool bValid;
	public string DeviceName;
	public FGuid ApplicationInstanceID;
	public EXRVisualType DeviceVisualType;
	public EControllerHand HandIndex;
	public ETrackingStatus TrackingStatus;
	public FVector GripPosition;
	public FQuat GripRotation;
	public FVector AimPosition;
	public FQuat AimRotation;
	public FVector PalmPosition;
	public FQuat PalmRotation;
	public TArray<FVector> HandKeyPositions;
	public TArray<FQuat> HandKeyRotations;
	public TArray<float> HandKeyRadii;
	public bool bIsGrasped;
}

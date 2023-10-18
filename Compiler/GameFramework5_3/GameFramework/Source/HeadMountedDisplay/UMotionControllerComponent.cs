namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotionControllerComponent.h")]
public partial class UMotionControllerComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Which player index this motion controller should automatically follow</summary>
	public int PlayerIndex;
	///<summary>Defines which pose this component should receive from the OpenXR Runtime. Left/Right MotionSource is the same as LeftGrip/RightGrip. See OpenXR specification for details on poses.</summary>
	public FName MotionSource;
	///<summary>If false, render transforms within the motion controller hierarchy will be updated a second time immediately before rendering.</summary>
	public bool bDisableLowLatencyUpdate;
	///<summary>The tracking status for the device (e.g. full tracking, inertial tracking only, no tracking)</summary>
	public ETrackingStatus CurrentTrackingStatus;
	///<summary>bDisplayDeviceModel</summary>
	public bool bDisplayDeviceModel;
	///<summary>DisplayModelSource</summary>
	public FName DisplayModelSource;
	///<summary>CustomDisplayMesh</summary>
	public UStaticMesh CustomDisplayMesh;
	///<summary>DisplayMeshMaterialOverrides</summary>
	public TArray<UMaterialInterface> DisplayMeshMaterialOverrides;
	///<summary>SetShowDeviceModel</summary>
	public void SetShowDeviceModel(bool bShowControllerModel) {}
	///<summary>SetDisplayModelSource</summary>
	public void SetDisplayModelSource(FName NewDisplayModelSource) {}
	///<summary>SetCustomDisplayMesh</summary>
	public void SetCustomDisplayMesh(UStaticMesh NewDisplayMesh) {}
	///<summary>Whether or not this component had a valid tracked device this frame</summary>
	public bool IsTracked() { return default; }
	///<summary>SetTrackingSource</summary>
	public void SetTrackingSource(EControllerHand NewSource) {}
	///<summary>GetTrackingSource</summary>
	public EControllerHand GetTrackingSource() { return default; }
	///<summary>SetTrackingMotionSource</summary>
	public void SetTrackingMotionSource(FName NewSource) {}
	///<summary>SetAssociatedPlayerIndex</summary>
	public void SetAssociatedPlayerIndex(int NewPlayer) {}
	///<summary>DisplayComponent</summary>
	public UPrimitiveComponent DisplayComponent;
	///<summary>Blueprint Implementable function for responding to updated data from a motion controller (so we can use custom parameter values from it)</summary>
	public void OnMotionControllerUpdated() {}
	///<summary>Returns the value of a custom parameter on the current in use Motion Controller (see member InUseMotionController). Only valid for the duration of OnMotionControllerUpdated</summary>
	public float GetParameterValue(FName InName,bool bValueFound) { return default; }
	///<summary>GetHandJointPosition</summary>
	public FVector GetHandJointPosition(int jointIndex,bool bValueFound) { return default; }
	///<summary>If the motion tracking system provides linear velocity at this time the vector will be that velocity in cm/s in unreal world space and the function will return true.  If velocity is unavailable it will return false.</summary>
	public bool GetLinearVelocity(FVector OutLinearVelocity) { return default; }
	///<summary>If the motion tracking system provides angular velocity at this time OutAngularVelocity will be that velocity in deg/s in unreal world space and the function will return true. Note that it is not difficult to rotate a controller at more than 0.5 or 1 rotation per second briefly and some mathmatical operations(such as conversion to quaternion) lose rotations beyond 180 degrees or 360 degrees..  In some cases that is OK becuase the resulting final rotation is the same, but in some cases it would generate incorrect results.   If angular velocity is unavailable it will return false.</summary>
	public bool GetAngularVelocity(FRotator OutAngularVelocity) { return default; }
	///<summary>If the motion tracking system provides linear acceleration at this time the vector will be that acceleration in cm/(s^2) in unreal world space and the function will return true.  If acceleration is unavailable it will return false.</summary>
	public bool GetLinearAcceleration(FVector OutLinearAcceleration) { return default; }
}

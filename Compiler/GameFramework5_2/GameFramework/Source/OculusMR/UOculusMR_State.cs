#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object to hold the state of MR capture and capturing camera</summary>
[CppInclude("OculusMR_State.h")]
public partial class UOculusMR_State : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TrackedCamera</summary>
	public FTrackedCamera TrackedCamera;
	///<summary>Component at the tracking origin that the camera calibration is applied to</summary>
	public USceneComponent TrackingReferenceComponent;
	///<summary>A multiplier on the camera distance, should be based on the scaling of the player component</summary>
	public double ScalingFactor;
	///<summary>Flag indicating a change in the tracked camera state for the camera actor to consume</summary>
	public bool ChangeCameraStateRequested;
	///<summary>Flag indicating a change in the tracked camera index for the camera actor to consume</summary>
	public bool BindToTrackedCameraIndexRequested;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusMR_State.h")]
///<summary>Object to hold the state of MR capture and capturing camera</summary>
public partial class UOculusMR_State : UObject {
// OculusMR_State
	public FTrackedCamera TrackedCamera;
	public USceneComponent TrackingReferenceComponent;
	public double ScalingFactor;
	public bool ChangeCameraStateRequested;
	public bool BindToTrackedCameraIndexRequested;
}

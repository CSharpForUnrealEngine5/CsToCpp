namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedPose : UARTrackedGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>GetTrackedPoseData</summary>
	public FARPose3D GetTrackedPoseData() { return default; }
	///<summary>The detailed info of the tracked pose</summary>
	public FARPose3D TrackedPose;
}

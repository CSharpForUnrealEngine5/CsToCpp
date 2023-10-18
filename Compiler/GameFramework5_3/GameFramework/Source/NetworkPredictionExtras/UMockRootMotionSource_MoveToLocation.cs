namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockRootMotionSourceObject.h")]
public partial class UMockRootMotionSource_MoveToLocation : UMockRootMotionSource {
	public static UClass StaticClass() {return default;}
	///<summary>SetDestination</summary>
	public void SetDestination(FVector InDestination) {}
	///<summary>Destination</summary>
	public FVector Destination;
	///<summary>Velocity</summary>
	public float Velocity;
	///<summary>SnapToTolerance</summary>
	public float SnapToTolerance;
}

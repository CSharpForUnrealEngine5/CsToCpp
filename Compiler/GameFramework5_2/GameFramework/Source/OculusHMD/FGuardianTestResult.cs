#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFunctionLibrary.h")]
///<summary>* Information about relationships between a triggered boundary (EBoundaryType::Boundary_Outer or</summary>
public partial struct FGuardianTestResult {
// GuardianTestResult
	public bool IsTriggering;
	public ETrackedDeviceType DeviceType;
	public float ClosestDistance;
	public FVector ClosestPoint;
	public FVector ClosestPointNormal;
}

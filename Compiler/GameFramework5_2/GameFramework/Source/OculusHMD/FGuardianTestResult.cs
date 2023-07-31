#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Information about relationships between a triggered boundary (EBoundaryType::Boundary_Outer or</summary>
[CppInclude("OculusFunctionLibrary.h")]
public partial struct FGuardianTestResult {
	public bool IsTriggering;
	public ETrackedDeviceType DeviceType;
	public float ClosestDistance;
	public FVector ClosestPoint;
	public FVector ClosestPointNormal;
}

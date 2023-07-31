#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoAxisSource : UInterface {
	///<summary>@return Origin Point of axis</summary>
	public  FVector GetOrigin() { return default; }
	///<summary>@return Direction Vector of axis</summary>
	public  FVector GetDirection() { return default; }
	///<summary>@return true if this AxisSource has tangent vectors orthogonal to the Direction vector</summary>
	public  bool HasTangentVectors() { return default; }
	///<summary>Get the two tangent vectors that are orthogonal to the Direction vector.</summary>
	public  void GetTangentVectors(FVector TangentXOut,FVector TangentYOut) {}
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoAxisSource : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>@return Origin Point of axis</summary>
	public virtual FVector GetOrigin() { return default; }
	///<summary>@return Direction Vector of axis</summary>
	public virtual FVector GetDirection() { return default; }
	///<summary>@return true if this AxisSource has tangent vectors orthogonal to the Direction vector</summary>
	public virtual bool HasTangentVectors() { return default; }
	///<summary>Get the two tangent vectors that are orthogonal to the Direction vector.</summary>
	public virtual void GetTangentVectors(FVector TangentXOut,FVector TangentYOut) {}
}

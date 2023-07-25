#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseGizmos/GizmoInterfaces.h")]
public partial class UGizmoAxisSource : UInterface {
// GizmoAxisSource
	public FVector GetOrigin() { return default; }
	public FVector GetDirection() { return default; }
	public bool HasTangentVectors() { return default; }
	public void GetTangentVectors(FVector TangentXOut,FVector TangentYOut) {}
}

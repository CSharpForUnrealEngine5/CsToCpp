#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusMR_PlaneMeshComponent.h")]
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
public partial class UOculusMR_PlaneMeshComponent : UMeshComponent {
// OculusMR_PlaneMeshComponent
	public  bool SetCustomMeshTriangles(TArray<FOculusMR_PlaneMeshTriangle> Triangles) { return default; }
	public  void AddCustomMeshTriangles(TArray<FOculusMR_PlaneMeshTriangle> Triangles) {}
	public  void ClearCustomMeshTriangles() {}
}

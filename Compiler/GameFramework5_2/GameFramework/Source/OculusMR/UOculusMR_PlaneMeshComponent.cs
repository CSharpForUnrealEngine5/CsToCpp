#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
[CppInclude("OculusMR_PlaneMeshComponent.h")]
public partial class UOculusMR_PlaneMeshComponent : UMeshComponent {
	///<summary>Set the geometry to use on this triangle mesh</summary>
	public  bool SetCustomMeshTriangles(TArray<FOculusMR_PlaneMeshTriangle> Triangles) { return default; }
	///<summary>Add to the geometry to use on this triangle mesh.  This may cause an allocation.  Use SetCustomMeshTriangles() instead when possible to reduce allocations.</summary>
	public  void AddCustomMeshTriangles(TArray<FOculusMR_PlaneMeshTriangle> Triangles) {}
	///<summary>Removes all geometry from this triangle mesh.  Does not deallocate memory, allowing new geometry to reuse the existing allocation.</summary>
	public  void ClearCustomMeshTriangles() {}
}

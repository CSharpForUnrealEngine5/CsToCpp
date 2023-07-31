#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
[CppInclude("CustomMeshComponent.h")]
public partial class UCustomMeshComponent : UMeshComponent {
	///<summary>Set the geometry to use on this triangle mesh</summary>
	public  bool SetCustomMeshTriangles(TArray<FCustomMeshTriangle> Triangles) { return default; }
	///<summary>Add to the geometry to use on this triangle mesh.  This may cause an allocation.  Use SetCustomMeshTriangles() instead when possible to reduce allocations.</summary>
	public  void AddCustomMeshTriangles(TArray<FCustomMeshTriangle> Triangles) {}
	///<summary>Removes all geometry from this triangle mesh.  Does not deallocate memory, allowing new geometry to reuse the existing allocation.</summary>
	public  void ClearCustomMeshTriangles() {}
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CustomMeshComponent.h")]
///<summary>Component that allows you to specify custom triangle mesh geometry</summary>
public partial class UCustomMeshComponent : UMeshComponent {
// CustomMeshComponent
	public  bool SetCustomMeshTriangles(TArray<FCustomMeshTriangle> Triangles) { return default; }
	public  void AddCustomMeshTriangles(TArray<FCustomMeshTriangle> Triangles) {}
	public  void ClearCustomMeshTriangles() {}
}

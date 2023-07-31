#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDynamicMesh is a UObject container for a FDynamicMesh3.</summary>
[CppInclude("UDynamicMesh.h")]
public partial class UDynamicMesh : UObject {
	///<summary>Clear the internal mesh to an empty mesh.</summary>
	public  UDynamicMesh Reset() { return default; }
	///<summary>Clear the internal mesh to a 100x100x100 cube with base at the origin.</summary>
	public  UDynamicMesh ResetToCube() { return default; }
	///<summary>@return true if the mesh has no triangles</summary>
	public  bool IsEmpty() { return default; }
	///<summary>@return number of triangles in the mesh</summary>
	public  int GetTriangleCount() { return default; }
	///<summary>Blueprintable event called when mesh is modified, in the same cases as OnMeshChanged</summary>
	public FOnDynamicMeshModifiedBP MeshModifiedBPEvent;
	///<summary>Active mesh generator. If configured, and bEnableMeshGenerator is true, then MeshGenerator-&gt;Generate()</summary>
	public UDynamicMeshGenerator MeshGenerator;
	///<summary>Controls whether the active Generator (if configured) will be applied when rebuilding the mesh</summary>
	public bool bEnableMeshGenerator;
}

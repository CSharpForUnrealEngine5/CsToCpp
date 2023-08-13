namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectionTool.h")]
public partial class UMeshSelectionMeshEditActions : UMeshSelectionToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Delete the selected triangles</summary>
	public void Delete() {}
	///<summary>Disconnected the selected triangles from their neighbours, to create mesh boundaries along the selection borders</summary>
	public void Disconnect() {}
	///<summary>Flip the normals of the selected triangles. This will create hard normals at selection borders.</summary>
	public void FlipNormals() {}
	///<summary>Assign a new unique Polygroup index to the selected triangles</summary>
	public void CreatePolygroup() {}
	///<summary>Delete the selected triangles from the active Mesh Object and create a new Mesh Object containing those triangles</summary>
	public void Separate() {}
	///<summary>Create a new Mesh Object containing the selected triangles</summary>
	public void Duplicate() {}
	///<summary>Smooth the selection border</summary>
	public void SmoothBorder() {}
}

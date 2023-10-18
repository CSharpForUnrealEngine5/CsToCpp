namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Convert a mesh to a string formatted as an OBJ file, which can be read by many external mesh viewers</summary>
[CppInclude("Dataflow/GeometryCollectionDebugNodes.h")]
public partial struct FMeshToOBJStringDebugDataflowNode {
	public UDynamicMesh Mesh;
	public bool bInvertFaces;
	public string StringOBJ;
}

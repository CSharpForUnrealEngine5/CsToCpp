namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Collects information from the DynamicMesh and outputs it into a formatted string</summary>
[CppInclude("Dataflow/GeometryCollectionMeshNodes.h")]
public partial struct FMeshInfoDataflowNode {
	public UDynamicMesh Mesh;
	public string InfoString;
}

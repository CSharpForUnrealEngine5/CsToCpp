#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ns UE</summary>
[CppInclude("InterchangeSkeletalMeshLodDataNode.h")]
public partial class UInterchangeSkeletalMeshLodDataNode : UInterchangeFactoryBaseNode {
	///<summary>Query the LOD skeletal mesh factory skeleton reference. Return false if the attribute was not set.</summary>
	public  bool GetCustomSkeletonUid(string AttributeValue) { return default; }
	///<summary>Set the LOD skeletal mesh factory skeleton reference. Return false if the attribute cannot be set.</summary>
	public  bool SetCustomSkeletonUid(string AttributeValue) { return default; }
	///<summary>Return the number of mesh geometry this LOD will be made of. Mesh uids can be either a scene or a mesh node. If its a scene it mean we want the mesh factory to bake the geo payload with the global transform of the scene node.</summary>
	public  int GetMeshUidsCount() { return default; }
	///<summary>Query all mesh geometry this LOD will be made of. Mesh uids can be either a scene or a mesh node. If its a scene it mean we want the mesh factory to bake the geo payload with the global transform of the scene node.</summary>
	public  void GetMeshUids(TArray<string> OutMeshNames) {}
	///<summary>Add one mesh geometry use to create this LOD geometry. Mesh uids can be either a scene or a mesh node. If its a scene it mean we want the mesh factory to bake the geo payload with the global transform of the scene node.</summary>
	public  bool AddMeshUid(string MeshName) { return default; }
	///<summary>Remove one mesh geometry use to create this LOD geometry. Mesh uids can be either a scene or a mesh node. If its a scene it mean we want the mesh factory to bake the geo payload with the global transform of the scene node.</summary>
	public  bool RemoveMeshUid(string MeshName) { return default; }
	///<summary>Remove all mesh geometry use to create this LOD geometry. Mesh uids can be either a scene or a mesh node. If its a scene it mean we want the mesh factory to bake the geo payload with the global transform of the scene node.</summary>
	public  bool RemoveAllMeshes() { return default; }
}

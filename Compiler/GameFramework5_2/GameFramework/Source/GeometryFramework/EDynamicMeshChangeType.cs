#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UDynamicMesh.h")]
///<summary>EDynamicMeshChangeType is used by FDynamicMeshChangeInfo to indicate a "type" of mesh change</summary>
public enum EDynamicMeshChangeType {
	GeneralEdit=0,
	MeshChange=1,
	MeshReplacementChange=2,
	MeshVertexChange=3,
	DeformationEdit=4,
	AttributeEdit=5,
}

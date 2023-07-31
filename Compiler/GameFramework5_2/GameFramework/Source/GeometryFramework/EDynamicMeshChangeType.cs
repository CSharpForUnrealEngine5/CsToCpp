#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UDynamicMesh.h")]
///<summary>EDynamicMeshChangeType is used by FDynamicMeshChangeInfo to indicate a &quot;type&quot; of mesh change</summary>
public enum EDynamicMeshChangeType {
	GeneralEdit=0,
	MeshChange=1,
	MeshReplacementChange=2,
	MeshVertexChange=3,
	DeformationEdit=4,
	AttributeEdit=5,
}

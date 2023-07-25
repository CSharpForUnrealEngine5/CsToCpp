#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UDynamicMesh.h")]
///<summary>FDynamicMeshChangeInfo stores information about a change to a UDynamicMesh.</summary>
public partial struct FDynamicMeshChangeInfo {
// DynamicMeshChangeInfo
	public EDynamicMeshChangeType Type;
	public EDynamicMeshAttributeChangeFlags Flags;
	public bool bIsRevertChange;
}

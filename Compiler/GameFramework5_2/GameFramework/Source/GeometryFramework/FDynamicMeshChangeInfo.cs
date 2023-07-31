#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FDynamicMeshChangeInfo stores information about a change to a UDynamicMesh.</summary>
[CppInclude("UDynamicMesh.h")]
public partial struct FDynamicMeshChangeInfo {
	public EDynamicMeshChangeType Type;
	public EDynamicMeshAttributeChangeFlags Flags;
	public bool bIsRevertChange;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* A mesh geometry is a description of a translated mesh asset node that define a geometry.</summary>
[CppInclude("InterchangePipelineMeshesUtilities.h")]
public partial struct FInterchangeMeshGeometry {
	public string MeshUid;
	public UInterchangeMeshNode MeshNode;
	public TArray<string> ReferencingMeshInstanceUids;
	public TArray<string> AttachedSocketUids;
}

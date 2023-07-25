#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectionSet.h")]
///<summary>UMeshSelectionSet is an implementation of USelectionSet that represents selections on indexed meshes.</summary>
public partial class UMeshSelectionSet : USelectionSet {
// MeshSelectionSet
	public TArray<int> Vertices;
	public TArray<int> Edges;
	public TArray<int> Faces;
	public TArray<int> Groups;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeshSelectionSet is an implementation of USelectionSet that represents selections on indexed meshes.</summary>
[CppInclude("SelectionSet.h")]
public partial class UMeshSelectionSet : USelectionSet {
	public static UClass StaticClass() {return default;}
	///<summary>Vertices</summary>
	public TArray<int> Vertices;
	///<summary>Edges</summary>
	public TArray<int> Edges;
	///<summary>Faces</summary>
	public TArray<int> Faces;
	///<summary>Groups</summary>
	public TArray<int> Groups;
}

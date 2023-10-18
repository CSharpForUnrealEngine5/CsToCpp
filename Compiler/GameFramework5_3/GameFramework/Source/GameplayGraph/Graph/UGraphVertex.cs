namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/GraphVertex.h")]
public partial class UGraphVertex : UGraphElement {
	public static UClass StaticClass() {return default;}
	///<summary>Edges</summary>
	public TMap<FGraphVertexHandle,FGraphEdgeHandle> Edges;
	///<summary>ParentIsland</summary>
	public FGraphIslandHandle ParentIsland;
}

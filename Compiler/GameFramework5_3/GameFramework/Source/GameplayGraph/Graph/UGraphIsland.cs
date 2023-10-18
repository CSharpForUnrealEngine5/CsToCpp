namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/GraphIsland.h")]
public partial class UGraphIsland : UGraphElement {
	public static UClass StaticClass() {return default;}
	///<summary>Vertices</summary>
	public TSet<FGraphVertexHandle> Vertices;
	///<summary>bPendingDestroy</summary>
	public bool bPendingDestroy;
}

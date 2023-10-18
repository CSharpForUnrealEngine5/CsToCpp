namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/GraphEdge.h")]
public partial class UGraphEdge : UGraphElement {
	public static UClass StaticClass() {return default;}
	///<summary>A</summary>
	public FGraphVertexHandle A;
	///<summary>B</summary>
	public FGraphVertexHandle B;
}

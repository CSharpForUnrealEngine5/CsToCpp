namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialGraph/MaterialGraphNode_Composite.h")]
public partial class UMaterialGraphNode_Composite : UMaterialGraphNode {
	public static UClass StaticClass() {return default;}
	///<summary>The graph that this composite node is representing</summary>
	public UMaterialGraph BoundGraph;
}

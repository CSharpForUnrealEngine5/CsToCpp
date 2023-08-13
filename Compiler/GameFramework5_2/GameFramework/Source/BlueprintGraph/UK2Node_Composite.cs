namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_Composite.h")]
public partial class UK2Node_Composite : UK2Node_Tunnel {
	public static UClass StaticClass() {return default;}
	///<summary>The graph that this composite node is representing</summary>
	public UEdGraph BoundGraph;
}

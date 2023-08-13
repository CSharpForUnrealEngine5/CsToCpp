namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_VariableGet.h")]
public partial class UK2Node_VariableGet : UK2Node_Variable {
	public static UClass StaticClass() {return default;}
	///<summary>TRUE if the node should function as a pure node, without exec pins</summary>
	public bool bIsPureGet;
}

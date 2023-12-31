namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Graph/ControlRigGraph.h")]
public partial class UControlRigGraph : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>ModelNodePath</summary>
	public string ModelNodePath;
	///<summary>bIsFunctionDefinition</summary>
	public bool bIsFunctionDefinition;
	///<summary>TemplateController</summary>
	public URigVMController TemplateController;
}

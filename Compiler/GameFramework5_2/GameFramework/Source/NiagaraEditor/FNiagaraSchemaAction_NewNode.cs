namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Action to add a node to the graph</summary>
[CppInclude("EdGraphSchema_Niagara.h")]
public partial struct FNiagaraSchemaAction_NewNode {
	public UEdGraphNode NodeTemplate;
	public string InternalName;
}

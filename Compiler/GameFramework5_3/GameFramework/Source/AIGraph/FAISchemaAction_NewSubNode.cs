namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Action to add a subnode to the selected node</summary>
[CppInclude("AIGraphSchema.h")]
public partial struct FAISchemaAction_NewSubNode {
	public UAIGraphNode NodeTemplate;
	public UAIGraphNode ParentNode;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Node that represents a graph output</summary>
[CppInclude("MetasoundEditorGraphNode.h")]
public partial class UMetasoundEditorGraphOutputNode : UMetasoundEditorGraphMemberNode {
	public static UClass StaticClass() {return default;}
	///<summary>Output</summary>
	public UMetasoundEditorGraphOutput Output;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for an input or output of the graph.</summary>
[CppInclude("MetasoundEditorGraph.h")]
public partial class UMetasoundEditorGraphVertex : UMetasoundEditorGraphMember {
	public static UClass StaticClass() {return default;}
	///<summary>ID of Metasound Frontend node.</summary>
	public FGuid NodeID;
	///<summary>Class name of Metasound Frontend node.</summary>
	public FMetasoundFrontendClassName ClassName;
}

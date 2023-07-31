#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for an input or output of the graph.</summary>
[CppInclude("MetasoundEditorGraph.h")]
public partial class UMetasoundEditorGraphVertex : UMetasoundEditorGraphMember {
	///<summary>ID of Metasound Frontend node.</summary>
	public FGuid NodeID;
	///<summary>Class name of Metasound Frontend node.</summary>
	public FMetasoundFrontendClassName ClassName;
}

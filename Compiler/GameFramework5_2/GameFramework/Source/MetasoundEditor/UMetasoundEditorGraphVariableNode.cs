#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundEditorGraphNode.h")]
///<summary>Represents any of the several variable node types (Accessor, DeferredAccessor, Mutator).</summary>
public partial class UMetasoundEditorGraphVariableNode : UMetasoundEditorGraphMemberNode {
// MetasoundEditorGraphVariableNode
	public EMetasoundFrontendClassType ClassType;
	public FMetasoundFrontendClassName ClassName;
	public FGuid NodeID;
	public UMetasoundEditorGraphVariable Variable;
}

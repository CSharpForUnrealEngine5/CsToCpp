#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents any of the several variable node types (Accessor, DeferredAccessor, Mutator).</summary>
[CppInclude("MetasoundEditorGraphNode.h")]
public partial class UMetasoundEditorGraphVariableNode : UMetasoundEditorGraphMemberNode {
	public static UClass StaticClass() {return default;}
	///<summary>Class type of the frontend node (Accessor, DeferredAccessor or Mutator)</summary>
	public EMetasoundFrontendClassType ClassType;
	///<summary>Class name of the frontend node.</summary>
	public FMetasoundFrontendClassName ClassName;
	///<summary>ID of the frontend node.</summary>
	public FGuid NodeID;
	///<summary>Associated graph variable.</summary>
	public UMetasoundEditorGraphVariable Variable;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
///<summary>Contains graph data associated with a variable.</summary>
public partial struct FMetasoundFrontendVariable {
// MetasoundFrontendVariable
	public string Name;
	public string DisplayName;
	public string Description;
	public string TypeName;
	public FMetasoundFrontendLiteral Literal;
	public FGuid ID;
	public FGuid VariableNodeID;
	public FGuid MutatorNodeID;
	public TArray<FGuid> AccessorNodeIDs;
	public TArray<FGuid> DeferredAccessorNodeIDs;
}

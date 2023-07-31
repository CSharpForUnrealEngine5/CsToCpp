#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains graph data associated with a variable.</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendVariable {
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

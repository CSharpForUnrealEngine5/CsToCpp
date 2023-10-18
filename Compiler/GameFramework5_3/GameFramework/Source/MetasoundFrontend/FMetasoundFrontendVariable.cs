namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains graph data associated with a variable.</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendVariable {
	public FName Name;
	public FText DisplayName;
	public FText Description;
	public FName TypeName;
	public FMetasoundFrontendLiteral Literal;
	public FGuid ID;
	public FGuid VariableNodeID;
	public FGuid MutatorNodeID;
	public TArray<FGuid> AccessorNodeIDs;
	public TArray<FGuid> DeferredAccessorNodeIDs;
}

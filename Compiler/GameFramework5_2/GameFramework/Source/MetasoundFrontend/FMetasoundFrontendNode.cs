#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
///<summary>An FMetasoundFrontendNode represents a single instance of a FMetasoundFrontendClass</summary>
public partial struct FMetasoundFrontendNode {
// MetasoundFrontendNode
	public FGuid ID;
	public FGuid ClassID;
	public string Name;
	public FMetasoundFrontendNodeInterface Interface;
	public TArray<FMetasoundFrontendVertexLiteral> InputLiterals;
	public FMetasoundFrontendNodeStyle Style;
}

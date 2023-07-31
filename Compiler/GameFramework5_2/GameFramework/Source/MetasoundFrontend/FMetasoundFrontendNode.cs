#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An FMetasoundFrontendNode represents a single instance of a FMetasoundFrontendClass</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendNode {
	public FGuid ID;
	public FGuid ClassID;
	public string Name;
	public FMetasoundFrontendNodeInterface Interface;
	public TArray<FMetasoundFrontendVertexLiteral> InputLiterals;
	public FMetasoundFrontendNodeStyle Style;
}

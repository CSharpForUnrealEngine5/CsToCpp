namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendGraph {
	public TArray<FMetasoundFrontendNode> Nodes;
	public TArray<FMetasoundFrontendEdge> Edges;
	public TArray<FMetasoundFrontendVariable> Variables;
	public FMetasoundFrontendGraphStyle Style;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
///<summary>Styling for all edges associated with a given output (characterized by NodeID & Name)</summary>
public partial struct FMetasoundFrontendEdgeStyle {
// MetasoundFrontendEdgeStyle
	public FGuid NodeID;
	public string OutputName;
	public TArray<FMetasoundFrontendEdgeStyleLiteralColorPair> LiteralColorPairs;
}

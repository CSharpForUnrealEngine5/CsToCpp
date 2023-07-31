#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Styling for all edges associated with a given output (characterized by NodeID &amp; Name)</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendEdgeStyle {
	public FGuid NodeID;
	public string OutputName;
	public TArray<FMetasoundFrontendEdgeStyleLiteralColorPair> LiteralColorPairs;
}

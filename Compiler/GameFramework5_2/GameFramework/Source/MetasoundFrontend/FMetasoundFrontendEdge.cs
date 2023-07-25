#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
///<summary>Represents a single connection from one point to another.</summary>
public partial struct FMetasoundFrontendEdge {
// MetasoundFrontendEdge
	public FGuid FromNodeID;
	public FGuid FromVertexID;
	public FGuid ToNodeID;
	public FGuid ToVertexID;
}

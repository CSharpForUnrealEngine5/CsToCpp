#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a single connection from one point to another.</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendEdge {
	public FGuid FromNodeID;
	public FGuid FromVertexID;
	public FGuid ToNodeID;
	public FGuid ToVertexID;
}

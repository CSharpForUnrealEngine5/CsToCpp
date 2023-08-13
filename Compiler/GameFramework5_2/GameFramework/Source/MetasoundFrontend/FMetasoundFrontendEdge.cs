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

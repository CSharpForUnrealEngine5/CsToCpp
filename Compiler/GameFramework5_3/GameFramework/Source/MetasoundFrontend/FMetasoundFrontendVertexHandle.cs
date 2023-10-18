namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pair of guids used to address location of vertex within a FrontendDocument graph</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendVertexHandle {
	public FGuid NodeID;
	public FGuid VertexID;
}

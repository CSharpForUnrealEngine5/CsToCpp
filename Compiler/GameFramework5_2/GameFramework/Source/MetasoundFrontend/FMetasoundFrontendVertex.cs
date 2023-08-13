namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An FMetasoundFrontendVertex provides a named connection point of a node.</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendVertex {
	public string Name;
	public string TypeName;
	public FGuid VertexID;
}

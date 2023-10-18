namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Definition of an interface that an FMetasoundFrontendClass adheres to in part or full.</summary>
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendInterface {
	public FMetasoundFrontendVersion Version;
	public TArray<FMetasoundFrontendInterfaceUClassOptions> UClassOptions;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendDocument {
// MetasoundFrontendDocument
	public FMetasoundFrontendDocumentMetadata Metadata;
	public TSet<FMetasoundFrontendVersion> Interfaces;
	public FMetasoundFrontendGraphClass RootGraph;
	public TArray<FMetasoundFrontendGraphClass> Subgraphs;
	public TArray<FMetasoundFrontendClass> Dependencies;
	public FMetasoundFrontendVersion ArchetypeVersion;
	public TArray<FMetasoundFrontendVersion> InterfaceVersions;
}

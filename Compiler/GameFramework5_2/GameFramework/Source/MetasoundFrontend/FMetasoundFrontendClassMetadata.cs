#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendClassMetadata {
// MetasoundFrontendClassMetadata
	public FMetasoundFrontendClassName ClassName;
	public FMetasoundFrontendVersionNumber Version;
	public EMetasoundFrontendClassType Type;
	public string DisplayName;
	public string DisplayNameTransient;
	public string Description;
	public string DescriptionTransient;
	public string PromptIfMissingTransient;
	public string Author;
	public TArray<string> Keywords;
	public TArray<string> KeywordsTransient;
	public TArray<string> CategoryHierarchy;
	public TArray<string> CategoryHierarchyTransient;
	public bool bIsDeprecated;
	public bool bAutoUpdateManagesInterface;
	public bool bSerializeText;
	public FGuid ChangeID;
}

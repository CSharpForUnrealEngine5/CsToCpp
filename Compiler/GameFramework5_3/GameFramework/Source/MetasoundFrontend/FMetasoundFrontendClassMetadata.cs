namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MetasoundFrontendDocument.h")]
public partial struct FMetasoundFrontendClassMetadata {
	public FMetasoundFrontendClassName ClassName;
	public FMetasoundFrontendVersionNumber Version;
	public EMetasoundFrontendClassType Type;
	public FText DisplayName;
	public FText DisplayNameTransient;
	public FText Description;
	public FText DescriptionTransient;
	public FText PromptIfMissingTransient;
	public string Author;
	public TArray<FText> Keywords;
	public TArray<FText> KeywordsTransient;
	public TArray<FText> CategoryHierarchy;
	public TArray<FText> CategoryHierarchyTransient;
	public bool bIsDeprecated;
	public bool bAutoUpdateManagesInterface;
	public bool bSerializeText;
	public FGuid ChangeID;
}

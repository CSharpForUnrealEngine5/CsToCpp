namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FGatherTextFromMetaDataConfiguration {
	public bool IsEnabled;
	public TArray<FGatherTextIncludePath> IncludePathWildcards;
	public TArray<FGatherTextExcludePath> ExcludePathWildcards;
	public TArray<FMetaDataKeyGatherSpecification> KeySpecifications;
	public TArray<string> FieldTypesToInclude;
	public TArray<string> FieldTypesToExclude;
	public TArray<string> FieldOwnerTypesToInclude;
	public TArray<string> FieldOwnerTypesToExclude;
	public bool ShouldGatherFromEditorOnlyData;
}

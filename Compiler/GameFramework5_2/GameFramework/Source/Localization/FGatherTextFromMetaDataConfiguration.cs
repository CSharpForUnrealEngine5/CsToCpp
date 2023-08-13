namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FGatherTextFromMetaDataConfiguration {
	public bool IsEnabled;
	public TArray<FGatherTextIncludePath> IncludePathWildcards;
	public TArray<FGatherTextExcludePath> ExcludePathWildcards;
	public TArray<FMetaDataKeyGatherSpecification> KeySpecifications;
	public bool ShouldGatherFromEditorOnlyData;
}

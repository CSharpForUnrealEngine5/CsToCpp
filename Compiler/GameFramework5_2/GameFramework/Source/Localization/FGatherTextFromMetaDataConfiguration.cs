#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FGatherTextFromMetaDataConfiguration {
// GatherTextFromMetaDataConfiguration
	public bool IsEnabled;
	public TArray<FGatherTextIncludePath> IncludePathWildcards;
	public TArray<FGatherTextExcludePath> ExcludePathWildcards;
	public TArray<FMetaDataKeyGatherSpecification> KeySpecifications;
	public bool ShouldGatherFromEditorOnlyData;
}

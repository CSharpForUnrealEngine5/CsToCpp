#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FGatherTextFromTextFilesConfiguration {
// GatherTextFromTextFilesConfiguration
	public bool IsEnabled;
	public TArray<FGatherTextSearchDirectory> SearchDirectories;
	public TArray<FGatherTextExcludePath> ExcludePathWildcards;
	public TArray<FGatherTextFileExtension> FileExtensions;
	public bool ShouldGatherFromEditorOnlyData;
}

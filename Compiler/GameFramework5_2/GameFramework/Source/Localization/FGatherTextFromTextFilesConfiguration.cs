namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LocalizationTargetTypes.h")]
public partial struct FGatherTextFromTextFilesConfiguration {
	public bool IsEnabled;
	public TArray<FGatherTextSearchDirectory> SearchDirectories;
	public TArray<FGatherTextExcludePath> ExcludePathWildcards;
	public TArray<FGatherTextFileExtension> FileExtensions;
	public bool ShouldGatherFromEditorOnlyData;
}

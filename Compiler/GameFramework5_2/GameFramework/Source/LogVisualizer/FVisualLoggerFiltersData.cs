#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogVisualizerSettings.h")]
public partial struct FVisualLoggerFiltersData {
// VisualLoggerFiltersData
	public string SearchBoxFilter;
	public string ObjectNameFilter;
	public TArray<FCategoryFilter> Categories;
	public TArray<string> SelectedClasses;
}

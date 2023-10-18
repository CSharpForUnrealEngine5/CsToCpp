namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogVisualizerSettings.h")]
public partial struct FVisualLoggerFiltersData {
	public string SearchBoxFilter;
	public string ObjectNameFilter;
	public TArray<FCategoryFilter> Categories;
	public TArray<string> SelectedClasses;
}

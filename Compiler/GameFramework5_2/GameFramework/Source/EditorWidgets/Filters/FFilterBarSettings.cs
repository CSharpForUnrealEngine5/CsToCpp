namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Filters/FilterBarConfig.h")]
public partial struct FFilterBarSettings {
	public TMap<string,bool> CustomFilters;
	public TMap<string,bool> TypeFilters;
	public TArray<FCustomTextFilterState> CustomTextFilters;
	public bool bIsLayoutSaved;
	public EFilterBarLayout FilterBarLayout;
}

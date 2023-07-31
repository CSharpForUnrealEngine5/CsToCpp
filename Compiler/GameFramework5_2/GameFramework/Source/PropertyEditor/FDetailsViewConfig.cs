#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DetailsViewConfig.h")]
public partial struct FDetailsViewConfig {
	public bool bShowFavoritesCategory;
	public bool bShowAllAdvanced;
	public bool bShowHiddenPropertiesWhilePlaying;
	public bool bShowAllChildrenIfCategoryMatches;
	public bool bShowOnlyKeyable;
	public bool bShowOnlyAnimated;
	public bool bShowOnlyModified;
	public bool bShowSections;
	public float ValueColumnWidth;
	public TMap<string,FDetailsSectionSelection> SelectedSections;
}

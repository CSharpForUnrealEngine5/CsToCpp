#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/DetailsView.h")]
///<summary>The details view allows you to display the value of an object properties.</summary>
public partial class UDetailsView : UPropertyViewBase {
// DetailsView
	public bool bAllowFiltering;
	public bool bAllowFavoriteSystem;
	public bool bShowModifiedPropertiesOption;
	public bool bShowKeyablePropertiesOption;
	public bool bShowAnimatedPropertiesOption;
	public float ColumnWidth;
	public bool bShowScrollBar;
	public bool bForceHiddenPropertyVisibility;
	public string ViewIdentifier;
	public TArray<string> CategoriesToShow;
	public TArray<string> PropertiesToShow;
	public bool bShowOnlyAllowed;
}

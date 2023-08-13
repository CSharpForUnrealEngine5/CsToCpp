namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The details view allows you to display the value of an object properties.</summary>
[CppInclude("Components/DetailsView.h")]
public partial class UDetailsView : UPropertyViewBase {
	public static UClass StaticClass() {return default;}
	///<summary>True if we allow filtering through search and the filter dropdown menu.</summary>
	public bool bAllowFiltering;
	///<summary>If false, the current properties editor will never display the favorite system</summary>
	public bool bAllowFavoriteSystem;
	///<summary>True if you want to show the &#39;Show Only Modified Properties&#39;. Only valid in conjunction with bAllowFiltering</summary>
	public bool bShowModifiedPropertiesOption;
	///<summary>True if you want to show the &#39;Show Only Keyable Properties&#39;. Only valid in conjunction with bAllowFiltering</summary>
	public bool bShowKeyablePropertiesOption;
	///<summary>True if you want to show the &#39;Show Only Animated Properties&#39;. Only valid in conjunction with bAllowFiltering</summary>
	public bool bShowAnimatedPropertiesOption;
	///<summary>The default column width</summary>
	public float ColumnWidth;
	///<summary>If false, the details panel&#39;s scrollbar will always be hidden. Useful when embedding details panels in widgets that either grow to accommodate them, or with scrollbars of their own.</summary>
	public bool bShowScrollBar;
	///<summary>If true, all properties will be visible, not just those with CPF_Edit</summary>
	public bool bForceHiddenPropertyVisibility;
	///<summary>Identifier for this details view; NAME_None if this view is anonymous</summary>
	public string ViewIdentifier;
	///<summary>Which categories to show in the details panel. If both this and the Properties To Show lists are empty, all properties will show.</summary>
	public TArray<string> CategoriesToShow;
	///<summary>Which properties to show in the details panel. If both this and the Categories To Show lists are empty, all properties will show.</summary>
	public TArray<string> PropertiesToShow;
	///<summary>Showing properties in this details panel works by allowing only specific categories and properties. This flag enables you to show all properties without needing to specify.</summary>
	public bool bShowOnlyAllowed;
}

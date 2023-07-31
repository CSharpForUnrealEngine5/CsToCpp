#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Blueprint Header View Plugin</summary>
[CppInclude("BlueprintHeaderViewSettings.h")]
public partial class UBlueprintHeaderViewSettings : UDeveloperSettings {
	///<summary>Syntax Highlighting colors for Blueprint Header View output</summary>
	public FHeaderViewSyntaxColors SyntaxColors;
	///<summary>Highlight color for selected items in the Blueprint Header View output</summary>
	public FLinearColor SelectionColor;
	///<summary>Font Size for the Blueprint Header View output</summary>
	public int FontSize;
	///<summary>Sorting Method for Header View Functions and Properties</summary>
	public EHeaderViewSortMethod SortMethod;
}

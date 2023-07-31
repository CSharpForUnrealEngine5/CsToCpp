#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A container for all accessible properties for a UWidget that will be passed to the underlying SWidget.</summary>
[CppInclude("Components/SlateWrapperTypes.h")]
public partial class USlateAccessibleWidgetData : UObject {
	///<summary>FGetText</summary>
	public  string FGetText() { return default; }
	///<summary>bCanChildrenBeAccessible</summary>
	public bool bCanChildrenBeAccessible;
	///<summary>AccessibleBehavior</summary>
	public ESlateAccessibleBehavior AccessibleBehavior;
	///<summary>AccessibleSummaryBehavior</summary>
	public ESlateAccessibleBehavior AccessibleSummaryBehavior;
	///<summary>AccessibleText</summary>
	public string AccessibleText;
	///<summary>AccessibleTextDelegate</summary>
	public FGetText AccessibleTextDelegate;
	///<summary>AccessibleSummaryText</summary>
	public string AccessibleSummaryText;
	///<summary>AccessibleSummaryTextDelegate</summary>
	public FGetText AccessibleSummaryTextDelegate;
}

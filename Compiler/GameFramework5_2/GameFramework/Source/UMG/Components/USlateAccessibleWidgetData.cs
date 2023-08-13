namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A container for all accessible properties for a UWidget that will be passed to the underlying SWidget.</summary>
[CppInclude("Components/SlateWrapperTypes.h")]
public partial class USlateAccessibleWidgetData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FGetText</summary>
	public FText FGetText() { return default; }
	///<summary>bCanChildrenBeAccessible</summary>
	public bool bCanChildrenBeAccessible;
	///<summary>AccessibleBehavior</summary>
	public ESlateAccessibleBehavior AccessibleBehavior;
	///<summary>AccessibleSummaryBehavior</summary>
	public ESlateAccessibleBehavior AccessibleSummaryBehavior;
	///<summary>AccessibleText</summary>
	public FText AccessibleText;
	///<summary>AccessibleTextDelegate</summary>
	public FGetText AccessibleTextDelegate;
	///<summary>AccessibleSummaryText</summary>
	public FText AccessibleSummaryText;
	///<summary>AccessibleSummaryTextDelegate</summary>
	public FGetText AccessibleSummaryTextDelegate;
}

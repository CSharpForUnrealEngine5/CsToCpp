#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SlateWrapperTypes.h")]
///<summary>A container for all accessible properties for a UWidget that will be passed to the underlying SWidget.</summary>
public partial class USlateAccessibleWidgetData : UObject {
// SlateAccessibleWidgetData
	public string FGetText() { return default; }
	public bool bCanChildrenBeAccessible;
	public ESlateAccessibleBehavior AccessibleBehavior;
	public ESlateAccessibleBehavior AccessibleSummaryBehavior;
	public string AccessibleText;
	public FGetText AccessibleTextDelegate;
	public string AccessibleSummaryText;
	public FGetText AccessibleSummaryTextDelegate;
}

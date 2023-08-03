#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A box populated with current actions available per CommonUI&#39;s Input Handler.</summary>
[CppInclude("Input/CommonBoundActionBar.h")]
public partial class UCommonBoundActionBar : UDynamicEntryBoxBase {
	public static UClass StaticClass() {return default;}
	///<summary>SetDisplayOwningPlayerActionsOnly</summary>
	public  void SetDisplayOwningPlayerActionsOnly(bool bShouldOnlyDisplayOwningPlayerActions) {}
	///<summary>ActionButtonClass</summary>
	public UClass ActionButtonClass;
	///<summary>bDisplayOwningPlayerActionsOnly</summary>
	public bool bDisplayOwningPlayerActionsOnly;
	///<summary>bIgnoreDuplicateActions</summary>
	public bool bIgnoreDuplicateActions;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Input/CommonBoundActionBar.h")]
///<summary>A box populated with current actions available per CommonUI's Input Handler.</summary>
public partial class UCommonBoundActionBar : UDynamicEntryBoxBase {
// CommonBoundActionBar
	public  void SetDisplayOwningPlayerActionsOnly(bool bShouldOnlyDisplayOwningPlayerActions) {}
	public UClass ActionButtonClass;
	public bool bDisplayOwningPlayerActionsOnly;
	public bool bIgnoreDuplicateActions;
}

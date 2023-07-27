#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/WidgetSwitcher.h")]
///<summary>A widget switcher is like a tab control, but without tabs. At most one widget is visible at time.</summary>
public partial class UWidgetSwitcher : UPanelWidget {
// WidgetSwitcher
	public int ActiveWidgetIndex;
	public  int GetNumWidgets() { return default; }
	public  int GetActiveWidgetIndex() { return default; }
	public  void SetActiveWidgetIndex(int Index) {}
	public  void SetActiveWidget(UWidget Widget) {}
	public  UWidget GetWidgetAtIndex(int Index) { return default; }
	public  UWidget GetActiveWidget() { return default; }
}

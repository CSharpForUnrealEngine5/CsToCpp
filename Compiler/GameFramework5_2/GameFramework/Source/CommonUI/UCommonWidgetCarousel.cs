#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonWidgetCarousel.h")]
///<summary>A widget switcher is like a tab control, but without tabs. At most one widget is visible at time.</summary>
public partial class UCommonWidgetCarousel : UPanelWidget {
// CommonWidgetCarousel
	public int ActiveWidgetIndex;
	public int GetActiveWidgetIndex() { return default; }
	public void SetActiveWidgetIndex(int Index) {}
	public void SetActiveWidget(UObject Widget) {}
	public UObject GetWidgetAtIndex(int Index) { return default; }
	public void BeginAutoScrolling(float ScrollInterval/*=10f*/) {}
	public void EndAutoScrolling() {}
	public void NextPage() {}
	public void PreviousPage() {}
	public FOnCurrentPageIndexChanged OnCurrentPageIndexChanged;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget switcher is like a tab control, but without tabs. At most one widget is visible at time.</summary>
[CppInclude("CommonWidgetCarousel.h")]
public partial class UCommonWidgetCarousel : UPanelWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The slot index to display</summary>
	public int ActiveWidgetIndex;
	///<summary>Gets the slot index of the currently active widget</summary>
	public  int GetActiveWidgetIndex() { return default; }
	///<summary>Activates the widget at the specified index.</summary>
	public  void SetActiveWidgetIndex(int Index) {}
	///<summary>Activates the widget and makes it the active index.</summary>
	public  void SetActiveWidget(UWidget Widget) {}
	///<summary>Get a widget at the provided index</summary>
	public  UWidget GetWidgetAtIndex(int Index) { return default; }
	///<summary>BeginAutoScrolling</summary>
	public  void BeginAutoScrolling(float ScrollInterval/*=10f*/) {}
	///<summary>EndAutoScrolling</summary>
	public  void EndAutoScrolling() {}
	///<summary>NextPage</summary>
	public  void NextPage() {}
	///<summary>PreviousPage</summary>
	public  void PreviousPage() {}
	///<summary>OnCurrentPageIndexChanged</summary>
	public FOnCurrentPageIndexChanged OnCurrentPageIndexChanged;
}

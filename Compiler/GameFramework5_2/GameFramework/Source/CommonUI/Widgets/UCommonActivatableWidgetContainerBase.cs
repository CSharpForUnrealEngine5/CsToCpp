#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base of widgets built to manage N activatable widgets, displaying one at a time.</summary>
[CppInclude("Widgets/CommonActivatableWidgetContainer.h")]
public partial class UCommonActivatableWidgetContainerBase : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>GetActiveWidget</summary>
	public  UCommonActivatableWidget GetActiveWidget() { return default; }
	///<summary>ClearWidgets</summary>
	public  void ClearWidgets() {}
	///<summary>SetTransitionDuration</summary>
	public  void SetTransitionDuration(float Duration) {}
	///<summary>GetTransitionDuration</summary>
	public  float GetTransitionDuration() { return default; }
	///<summary>The type of transition to play between widgets</summary>
	public ECommonSwitcherTransition TransitionType;
	///<summary>The curve function type to apply to the transition animation</summary>
	public ETransitionCurve TransitionCurveType;
	///<summary>The total duration of a single transition between widgets</summary>
	public float TransitionDuration;
	///<summary>WidgetList</summary>
	public TArray<UCommonActivatableWidget> WidgetList;
	///<summary>DisplayedWidget</summary>
	public UCommonActivatableWidget DisplayedWidget;
	///<summary>GeneratedWidgetsPool</summary>
	public FUserWidgetPool GeneratedWidgetsPool;
	///<summary>Adds a widget of the given class to the container.</summary>
	public  UCommonActivatableWidget BP_AddWidget(UClass ActivatableWidgetClass) { return default; }
	///<summary>RemoveWidget</summary>
	public  void RemoveWidget(UCommonActivatableWidget WidgetToRemove) {}
}

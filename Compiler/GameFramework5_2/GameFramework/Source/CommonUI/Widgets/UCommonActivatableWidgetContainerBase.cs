#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Widgets/CommonActivatableWidgetContainer.h")]
///<summary>Base of widgets built to manage N activatable widgets, displaying one at a time.</summary>
public partial class UCommonActivatableWidgetContainerBase : UWidget {
// CommonActivatableWidgetContainerBase
	public UObject GetActiveWidget() { return default; }
	public void ClearWidgets() {}
	public void SetTransitionDuration(float Duration) {}
	public float GetTransitionDuration() { return default; }
	public ECommonSwitcherTransition TransitionType;
	public ETransitionCurve TransitionCurveType;
	public float TransitionDuration;
	public TArray<UCommonActivatableWidget> WidgetList;
	public UCommonActivatableWidget DisplayedWidget;
	public FUserWidgetPool GeneratedWidgetsPool;
	public UObject BP_AddWidget(UClass ActivatableWidgetClass) { return default; }
	public void RemoveWidget(UObject WidgetToRemove) {}
}

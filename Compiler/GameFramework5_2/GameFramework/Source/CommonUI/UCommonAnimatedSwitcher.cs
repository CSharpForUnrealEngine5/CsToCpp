#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget switcher that activates / deactivates CommonActivatableWidgets, allowing for associated animations to trigger.</summary>
[CppInclude("CommonAnimatedSwitcher.h")]
public partial class UCommonAnimatedSwitcher : UWidgetSwitcher {
	public static UClass StaticClass() {return default;}
	///<summary>ActivateNextWidget</summary>
	public  void ActivateNextWidget(bool bCanWrap) {}
	///<summary>ActivatePreviousWidget</summary>
	public  void ActivatePreviousWidget(bool bCanWrap) {}
	///<summary>HasWidgets</summary>
	public  bool HasWidgets() { return default; }
	///<summary>SetDisableTransitionAnimation</summary>
	public  void SetDisableTransitionAnimation(bool bDisableAnimation) {}
	///<summary>IsCurrentlySwitching</summary>
	public  bool IsCurrentlySwitching() { return default; }
	///<summary>Is the switcher playing a transition animation?</summary>
	public  bool IsTransitionPlaying() { return default; }
	///<summary>The type of transition to play between widgets</summary>
	public ECommonSwitcherTransition TransitionType;
	///<summary>The curve function type to apply to the transition animation</summary>
	public ETransitionCurve TransitionCurveType;
	///<summary>The total duration of a single transition between widgets</summary>
	public float TransitionDuration;
}

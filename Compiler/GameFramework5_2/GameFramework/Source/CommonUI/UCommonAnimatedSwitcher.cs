#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonAnimatedSwitcher.h")]
///<summary>A widget switcher that activates / deactivates CommonActivatableWidgets, allowing for associated animations to trigger.</summary>
public partial class UCommonAnimatedSwitcher : UWidgetSwitcher {
// CommonAnimatedSwitcher
	public  void ActivateNextWidget(bool bCanWrap) {}
	public  void ActivatePreviousWidget(bool bCanWrap) {}
	public  bool HasWidgets() { return default; }
	public  void SetDisableTransitionAnimation(bool bDisableAnimation) {}
	public  bool IsCurrentlySwitching() { return default; }
	public  bool IsTransitionPlaying() { return default; }
	public ECommonSwitcherTransition TransitionType;
	public ETransitionCurve TransitionCurveType;
	public float TransitionDuration;
}

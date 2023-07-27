#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/Button.h")]
///<summary>The button is a click-able primitive widget to enable basic interaction, you</summary>
public partial class UButton : UContentWidget {
// Button
	public FButtonStyle WidgetStyle;
	public FLinearColor ColorAndOpacity;
	public FLinearColor BackgroundColor;
	public EButtonClickMethod ClickMethod;
	public EButtonTouchMethod TouchMethod;
	public EButtonPressMethod PressMethod;
	public bool IsFocusable;
	public FOnButtonClickedEvent OnClicked;
	public FOnButtonPressedEvent OnPressed;
	public FOnButtonReleasedEvent OnReleased;
	public FOnButtonHoverEvent OnHovered;
	public FOnButtonHoverEvent OnUnhovered;
	public  void SetStyle(FButtonStyle InStyle) {}
	public  void SetColorAndOpacity(FLinearColor InColorAndOpacity) {}
	public  void SetBackgroundColor(FLinearColor InBackgroundColor) {}
	public  bool IsPressed() { return default; }
	public  void SetClickMethod(EButtonClickMethod InClickMethod) {}
	public  void SetTouchMethod(EButtonTouchMethod InTouchMethod) {}
	public  void SetPressMethod(EButtonPressMethod InPressMethod) {}
}

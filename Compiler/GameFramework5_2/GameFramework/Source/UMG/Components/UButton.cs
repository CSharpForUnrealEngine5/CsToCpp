namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The button is a click-able primitive widget to enable basic interaction, you</summary>
[CppInclude("Components/Button.h")]
public partial class UButton : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The button style used at runtime</summary>
	public FButtonStyle WidgetStyle;
	///<summary>The color multiplier for the button content</summary>
	public FLinearColor ColorAndOpacity;
	///<summary>The color multiplier for the button background</summary>
	public FLinearColor BackgroundColor;
	///<summary>The type of mouse action required by the user to trigger the buttons &#39;Click&#39;</summary>
	public EButtonClickMethod ClickMethod;
	///<summary>The type of touch action required by the user to trigger the buttons &#39;Click&#39;</summary>
	public EButtonTouchMethod TouchMethod;
	///<summary>The type of keyboard/gamepad button press action required by the user to trigger the buttons &#39;Click&#39;</summary>
	public EButtonPressMethod PressMethod;
	///<summary>Sometimes a button should only be mouse-clickable and never keyboard focusable.</summary>
	public bool IsFocusable;
	///<summary>Called when the button is clicked</summary>
	public FOnButtonClickedEvent OnClicked;
	///<summary>Called when the button is pressed</summary>
	public FOnButtonPressedEvent OnPressed;
	///<summary>Called when the button is released</summary>
	public FOnButtonReleasedEvent OnReleased;
	///<summary>OnHovered</summary>
	public FOnButtonHoverEvent OnHovered;
	///<summary>OnUnhovered</summary>
	public FOnButtonHoverEvent OnUnhovered;
	///<summary>Sets the color multiplier for the button background</summary>
	public void SetStyle(FButtonStyle InStyle) {}
	///<summary>Sets the color multiplier for the button content</summary>
	public void SetColorAndOpacity(FLinearColor InColorAndOpacity) {}
	///<summary>Sets the color multiplier for the button background</summary>
	public void SetBackgroundColor(FLinearColor InBackgroundColor) {}
	///<summary>Returns true if the user is actively pressing the button.  Do not use this for detecting &#39;Clicks&#39;, use the OnClicked event instead.</summary>
	public bool IsPressed() { return default; }
	///<summary>SetClickMethod</summary>
	public void SetClickMethod(EButtonClickMethod InClickMethod) {}
	///<summary>SetTouchMethod</summary>
	public void SetTouchMethod(EButtonTouchMethod InTouchMethod) {}
	///<summary>SetPressMethod</summary>
	public void SetPressMethod(EButtonPressMethod InPressMethod) {}
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The checkbox widget allows you to display a toggled state of &#39;unchecked&#39;, &#39;checked&#39; and</summary>
[CppInclude("Components/CheckBox.h")]
public partial class UCheckBox : UContentWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the check box is currently in a checked state</summary>
	public ECheckBoxState CheckedState;
	///<summary>A bindable delegate for the IsChecked.</summary>
	public FGetCheckBoxState CheckedStateDelegate;
	///<summary>The checkbox bar style</summary>
	public FCheckBoxStyle WidgetStyle;
	///<summary>How the content of the toggle button should align within the given space</summary>
	public EHorizontalAlignment HorizontalAlignment;
	///<summary>The type of mouse action required by the user to trigger the buttons &#39;Click&#39;</summary>
	public EButtonClickMethod ClickMethod;
	///<summary>The type of touch action required by the user to trigger the buttons &#39;Click&#39;</summary>
	public EButtonTouchMethod TouchMethod;
	///<summary>The type of keyboard/gamepad button press action required by the user to trigger the buttons &#39;Click&#39;</summary>
	public EButtonPressMethod PressMethod;
	///<summary>Sometimes a button should only be mouse-clickable and never keyboard focusable.</summary>
	public bool IsFocusable;
	///<summary>Called when the checked state has changed</summary>
	public FOnCheckBoxComponentStateChanged OnCheckStateChanged;
	///<summary>Returns true if this button is currently pressed</summary>
	public bool IsPressed() { return default; }
	///<summary>Returns true if the checkbox is currently checked</summary>
	public bool IsChecked() { return default; }
	///<summary>Returns the full current checked state.</summary>
	public ECheckBoxState GetCheckedState() { return default; }
	///<summary>Sets the checked state.</summary>
	public void SetIsChecked(bool InIsChecked) {}
	///<summary>Sets the checked state.</summary>
	public void SetCheckedState(ECheckBoxState InCheckedState) {}
	///<summary>Sets the click method.</summary>
	public void SetClickMethod(EButtonClickMethod InClickMethod) {}
	///<summary>Sets the touch method.</summary>
	public void SetTouchMethod(EButtonTouchMethod InTouchMethod) {}
	///<summary>Sets the press method.</summary>
	public void SetPressMethod(EButtonPressMethod InPressMethod) {}
}

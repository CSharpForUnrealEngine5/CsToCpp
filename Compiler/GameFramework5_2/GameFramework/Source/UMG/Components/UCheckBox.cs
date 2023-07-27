#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/CheckBox.h")]
///<summary>The checkbox widget allows you to display a toggled state of 'unchecked', 'checked' and</summary>
public partial class UCheckBox : UContentWidget {
// CheckBox
	public ECheckBoxState CheckedState;
	public FGetCheckBoxState CheckedStateDelegate;
	public FCheckBoxStyle WidgetStyle;
	public byte HorizontalAlignment;
	public byte ClickMethod;
	public byte TouchMethod;
	public byte PressMethod;
	public bool IsFocusable;
	public FOnCheckBoxComponentStateChanged OnCheckStateChanged;
	public  bool IsPressed() { return default; }
	public  bool IsChecked() { return default; }
	public  ECheckBoxState GetCheckedState() { return default; }
	public  void SetIsChecked(bool InIsChecked) {}
	public  void SetCheckedState(ECheckBoxState InCheckedState) {}
	public  void SetClickMethod(EButtonClickMethod InClickMethod) {}
	public  void SetTouchMethod(EButtonTouchMethod InTouchMethod) {}
	public  void SetPressMethod(EButtonPressMethod InPressMethod) {}
}

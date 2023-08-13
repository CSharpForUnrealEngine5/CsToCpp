namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A widget for selecting a single key or a single key with a modifier.</summary>
[CppInclude("Components/InputKeySelector.h")]
public partial class UInputKeySelector : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FOnKeySelected</summary>
	public void FOnKeySelected(FInputChord SelectedKey) {}
	///<summary>FOnIsSelectingKeyChanged</summary>
	public void FOnIsSelectingKeyChanged() {}
	///<summary>The button style used at runtime</summary>
	public FButtonStyle WidgetStyle;
	///<summary>The button style used at runtime</summary>
	public FTextBlockStyle TextStyle;
	///<summary>The currently selected key chord.</summary>
	public FInputChord SelectedKey;
	///<summary>The amount of blank space around the text used to display the currently selected key.</summary>
	public FMargin Margin;
	///<summary>Sets the text which is displayed while selecting keys.</summary>
	public FText KeySelectionText;
	///<summary>Sets the text to display when no key text is available or not selecting a key.</summary>
	public FText NoKeySpecifiedText;
	///<summary>When true modifier keys such as control and alt are allowed in the</summary>
	public bool bAllowModifierKeys;
	///<summary>When true gamepad keys are allowed in the input chord representing the selected key, otherwise they are ignored.</summary>
	public bool bAllowGamepadKeys;
	///<summary>When true gamepad keys are allowed in the input chord representing the selected key, otherwise they are ignored.</summary>
	public TArray<FKey> EscapeKeys;
	///<summary>Called whenever a new key is selected by the user.</summary>
	public FOnKeySelected OnKeySelected;
	///<summary>Called whenever the key selection mode starts or stops.</summary>
	public FOnIsSelectingKeyChanged OnIsSelectingKeyChanged;
	///<summary>Sets the currently selected key.</summary>
	public void SetSelectedKey(FInputChord InSelectedKey) {}
	///<summary>Sets the text which is displayed while selecting keys.</summary>
	public void SetKeySelectionText(FText InKeySelectionText) {}
	///<summary>Sets the text to display when no key text is available or not selecting a key.</summary>
	public void SetNoKeySpecifiedText(FText InNoKeySpecifiedText) {}
	///<summary>Sets whether or not modifier keys are allowed in the selected key.</summary>
	public void SetAllowModifierKeys(bool bInAllowModifierKeys) {}
	///<summary>Sets whether or not gamepad keys are allowed in the selected key.</summary>
	public void SetAllowGamepadKeys(bool bInAllowGamepadKeys) {}
	///<summary>Returns true if the widget is currently selecting a key, otherwise returns false.</summary>
	public bool GetIsSelectingKey() { return default; }
	///<summary>Sets the visibility of the text block.</summary>
	public void SetTextBlockVisibility(ESlateVisibility InVisibility) {}
	///<summary>Sets escape keys.</summary>
	public void SetEscapeKeys(TArray<FKey> InKeys) {}
}

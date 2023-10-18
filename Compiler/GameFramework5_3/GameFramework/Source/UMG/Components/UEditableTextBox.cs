namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows the user to type in custom text.  Only permits a single line of text to be entered.</summary>
[CppInclude("Components/EditableTextBox.h")]
public partial class UEditableTextBox : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FOnEditableTextBoxChangedEvent</summary>
	public void FOnEditableTextBoxChangedEvent(FText Text) {}
	///<summary>FOnEditableTextBoxCommittedEvent</summary>
	public void FOnEditableTextBoxCommittedEvent(FText Text,ETextCommit CommitMethod) {}
	///<summary>The text content for this editable text box widget</summary>
	public FText Text;
	///<summary>A bindable delegate to allow logic to drive the text of the widget</summary>
	public FGetText TextDelegate;
	///<summary>The style</summary>
	public FEditableTextBoxStyle WidgetStyle;
	///<summary>Hint text that appears when there is no text in the text box</summary>
	public FText HintText;
	///<summary>A bindable delegate to allow logic to drive the hint text of the widget</summary>
	public FGetText HintTextDelegate;
	///<summary>Sets the Text Box as Readonly to prevent it from being modified interactively by the user</summary>
	public bool IsReadOnly;
	///<summary>Sets whether this text box is for storing a password</summary>
	public bool IsPassword;
	///<summary>The minimum desired size for the text</summary>
	public float MinimumDesiredWidth;
	///<summary>Workaround as we lose focus when the auto completion closes.</summary>
	public bool IsCaretMovedWhenGainFocus;
	///<summary>Whether to select all text when the user clicks to give focus on the widget</summary>
	public bool SelectAllTextWhenFocused;
	///<summary>Whether to allow the user to back out of changes when they press the escape key</summary>
	public bool RevertTextOnEscape;
	///<summary>Whether to clear keyboard focus when pressing enter to commit changes</summary>
	public bool ClearKeyboardFocusOnCommit;
	///<summary>Whether to select all text when pressing enter to commit changes</summary>
	public bool SelectAllTextOnCommit;
	///<summary>Whether the context menu can be opened</summary>
	public bool AllowContextMenu;
	///<summary>If we&#39;re on a platform that requires a virtual keyboard, what kind of keyboard should this widget use?</summary>
	public EVirtualKeyboardType KeyboardType;
	///<summary>Additional options to use for the virtual keyboard summoned by this widget</summary>
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	///<summary>The type of event that will trigger the display of the virtual keyboard</summary>
	public EVirtualKeyboardTrigger VirtualKeyboardTrigger;
	///<summary>What action should be taken when the virtual keyboard is dismissed?</summary>
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	///<summary>How the text should be aligned with the margin.</summary>
	public ETextJustify Justification;
	///<summary>Sets what happens to text that is clipped and doesn&#39;t fit within the clip rect for this widget</summary>
	public ETextOverflowPolicy OverflowPolicy;
	///<summary>Controls how the text within this widget should be shaped.</summary>
	public FShapedTextOptions ShapedTextOptions;
	///<summary>Called whenever the text is changed programmatically or interactively by the user</summary>
	public FOnEditableTextBoxChangedEvent OnTextChanged;
	///<summary>Called whenever the text is committed.  This happens when the user presses enter or the text box loses focus.</summary>
	public FOnEditableTextBoxCommittedEvent OnTextCommitted;
	///<summary>Gets the widget text</summary>
	public FText GetText() { return default; }
	///<summary>Directly sets the widget text.</summary>
	public void SetText(FText InText) {}
	///<summary>Sets the Hint text that appears when there is no text in the text box</summary>
	public void SetHintText(FText InText) {}
	///<summary>SetError</summary>
	public void SetError(FText InError) {}
	///<summary>Sets the Text as Readonly to prevent it from being modified interactively by the user</summary>
	public void SetIsReadOnly(bool bReadOnly) {}
	///<summary>SetIsPassword</summary>
	public void SetIsPassword(bool bIsPassword) {}
	///<summary>ClearError</summary>
	public void ClearError() {}
	///<summary>HasError</summary>
	public bool HasError() { return default; }
	///<summary>SetJustification</summary>
	public void SetJustification(ETextJustify InJustification) {}
	///<summary>Set the text overflow policy for this text box.</summary>
	public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	///<summary>SetForegroundColor</summary>
	public void SetForegroundColor(FLinearColor color) {}
	///<summary>bIsFontDeprecationDone</summary>
	public bool bIsFontDeprecationDone;
}

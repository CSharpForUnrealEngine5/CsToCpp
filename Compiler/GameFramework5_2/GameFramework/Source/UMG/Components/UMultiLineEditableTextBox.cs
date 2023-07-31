#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows a user to enter multiple lines of text</summary>
[CppInclude("Components/MultiLineEditableTextBox.h")]
public partial class UMultiLineEditableTextBox : UTextLayoutWidget {
	///<summary>FOnMultiLineEditableTextBoxChangedEvent</summary>
	public  void FOnMultiLineEditableTextBoxChangedEvent(string Text) {}
	///<summary>FOnMultiLineEditableTextBoxCommittedEvent</summary>
	public  void FOnMultiLineEditableTextBoxCommittedEvent(string Text,ETextCommit CommitMethod) {}
	///<summary>The text content for this editable text box widget</summary>
	public string Text;
	///<summary>Hint text that appears when there is no text in the text box</summary>
	public string HintText;
	///<summary>A bindable delegate to allow logic to drive the hint text of the widget</summary>
	public FGetText HintTextDelegate;
	///<summary>The style</summary>
	public FEditableTextBoxStyle WidgetStyle;
	///<summary>The text style</summary>
	public FTextBlockStyle TextStyle_DEPRECATED;
	///<summary>Sets the Text as Readonly to prevent it from being modified interactively by the user</summary>
	public bool bIsReadOnly;
	///<summary>Whether the context menu can be opened</summary>
	public bool AllowContextMenu;
	///<summary>Additional options to be used by the virtual keyboard summoned from this widget</summary>
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	///<summary>What action should be taken when the virtual keyboard is dismissed?</summary>
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	///<summary>Called whenever the text is changed programmatically or interactively by the user</summary>
	public FOnMultiLineEditableTextBoxChangedEvent OnTextChanged;
	///<summary>Called whenever the text is committed.  This happens when the user presses enter or the text box loses focus.</summary>
	public FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted;
	///<summary>Gets the widget text</summary>
	public  string GetText() { return default; }
	///<summary>Directly sets the widget text.</summary>
	public  void SetText(string InText) {}
	///<summary>Returns the Hint text that appears when there is no text in the text box</summary>
	public  string GetHintText() { return default; }
	///<summary>Sets the Hint text that appears when there is no text in the text box</summary>
	public  void SetHintText(string InHintText) {}
	///<summary>SetError</summary>
	public  void SetError(string InError) {}
	///<summary>Sets the Text as Readonly to prevent it from being modified interactively by the user</summary>
	public  void SetIsReadOnly(bool bReadOnly) {}
	///<summary>SetTextStyle</summary>
	public  void SetTextStyle(FTextBlockStyle InTextStyle) {}
	///<summary>SetForegroundColor</summary>
	public  void SetForegroundColor(FLinearColor color) {}
	///<summary>bIsFontDeprecationDone</summary>
	public bool bIsFontDeprecationDone;
}

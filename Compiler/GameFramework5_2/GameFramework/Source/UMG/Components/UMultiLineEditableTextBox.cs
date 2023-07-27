#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MultiLineEditableTextBox.h")]
///<summary>Allows a user to enter multiple lines of text</summary>
public partial class UMultiLineEditableTextBox : UTextLayoutWidget {
// MultiLineEditableTextBox
	public  void FOnMultiLineEditableTextBoxChangedEvent(string Text) {}
	public  void FOnMultiLineEditableTextBoxCommittedEvent(string Text,ETextCommit CommitMethod) {}
	public string Text;
	public string HintText;
	public FGetText HintTextDelegate;
	public FEditableTextBoxStyle WidgetStyle;
	public FTextBlockStyle TextStyle_DEPRECATED;
	public bool bIsReadOnly;
	public bool AllowContextMenu;
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	public FOnMultiLineEditableTextBoxChangedEvent OnTextChanged;
	public FOnMultiLineEditableTextBoxCommittedEvent OnTextCommitted;
	public  string GetText() { return default; }
	public  void SetText(string InText) {}
	public  string GetHintText() { return default; }
	public  void SetHintText(string InHintText) {}
	public  void SetError(string InError) {}
	public  void SetIsReadOnly(bool bReadOnly) {}
	public  void SetTextStyle(FTextBlockStyle InTextStyle) {}
	public  void SetForegroundColor(FLinearColor color) {}
	public bool bIsFontDeprecationDone;
}

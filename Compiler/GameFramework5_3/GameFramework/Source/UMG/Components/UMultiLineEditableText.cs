namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable text box widget</summary>
[CppInclude("Components/MultiLineEditableText.h")]
public partial class UMultiLineEditableText : UTextLayoutWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FOnMultiLineEditableTextChangedEvent</summary>
	public void FOnMultiLineEditableTextChangedEvent(FText Text) {}
	///<summary>FOnMultiLineEditableTextCommittedEvent</summary>
	public void FOnMultiLineEditableTextCommittedEvent(FText Text,ETextCommit CommitMethod) {}
	///<summary>The text content for this editable text box widget</summary>
	public FText Text;
	///<summary>Hint text that appears when there is no text in the text box</summary>
	public FText HintText;
	///<summary>A bindable delegate to allow logic to drive the hint text of the widget</summary>
	public FGetText HintTextDelegate;
	///<summary>The style</summary>
	public FTextBlockStyle WidgetStyle;
	///<summary>Sets the Text as Readonly to prevent it from being modified interactively by the user</summary>
	public bool bIsReadOnly;
	///<summary>Whether to select all text when the user clicks to give focus on the widget</summary>
	public bool SelectAllTextWhenFocused;
	///<summary>Whether to clear text selection when focus is lost</summary>
	public bool ClearTextSelectionOnFocusLoss;
	///<summary>Whether to allow the user to back out of changes when they press the escape key</summary>
	public bool RevertTextOnEscape;
	///<summary>Whether to clear keyboard focus when pressing enter to commit changes</summary>
	public bool ClearKeyboardFocusOnCommit;
	///<summary>Whether the context menu can be opened</summary>
	public bool AllowContextMenu;
	///<summary>Additional options for the virtual keyboard</summary>
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	///<summary>What action should be taken when the virtual keyboard is dismissed?</summary>
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	///<summary>Called whenever the text is changed programmatically or interactively by the user</summary>
	public FOnMultiLineEditableTextChangedEvent OnTextChanged;
	///<summary>Called whenever the text is committed.  This happens when the user presses enter or the text box loses focus.</summary>
	public FOnMultiLineEditableTextCommittedEvent OnTextCommitted;
	///<summary>Gets the widget text</summary>
	public FText GetText() { return default; }
	///<summary>Directly sets the widget text.</summary>
	public void SetText(FText InText) {}
	///<summary>Returns the Hint text that appears when there is no text in the text box</summary>
	public FText GetHintText() { return default; }
	///<summary>Sets the Hint text that appears when there is no text in the text box</summary>
	public void SetHintText(FText InHintText) {}
	///<summary>Sets the Text as Readonly to prevent it from being modified interactively by the user</summary>
	public void SetIsReadOnly(bool bReadOnly) {}
	///<summary>SetWidgetStyle</summary>
	public void SetWidgetStyle(FTextBlockStyle InWidgetStyle) {}
	///<summary>GetFont</summary>
	public FSlateFontInfo GetFont() { return default; }
	///<summary>SetFont</summary>
	public void SetFont(FSlateFontInfo InFontInfo) {}
	///<summary>SetFontMaterial</summary>
	public void SetFontMaterial(UMaterialInterface InMaterial) {}
	///<summary>SetFontOutlineMaterial</summary>
	public void SetFontOutlineMaterial(UMaterialInterface InMaterial) {}
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editable text box widget</summary>
[CppInclude("Components/EditableText.h")]
public partial class UEditableText : UWidget {
	///<summary>FOnEditableTextChangedEvent</summary>
	public  void FOnEditableTextChangedEvent(string Text) {}
	///<summary>FOnEditableTextCommittedEvent</summary>
	public  void FOnEditableTextCommittedEvent(string Text,ETextCommit CommitMethod) {}
	///<summary>The text content for this editable text box widget</summary>
	public string Text;
	///<summary>A bindable delegate to allow logic to drive the text of the widget</summary>
	public FGetText TextDelegate;
	///<summary>Hint text that appears when there is no text in the text box</summary>
	public string HintText;
	///<summary>A bindable delegate to allow logic to drive the hint text of the widget</summary>
	public FGetText HintTextDelegate;
	///<summary>The style</summary>
	public FEditableTextStyle WidgetStyle;
	///<summary>Sets whether this text box can actually be modified interactively by the user</summary>
	public bool IsReadOnly;
	///<summary>Sets whether this text box is for storing a password</summary>
	public bool IsPassword;
	///<summary>The minimum desired Width for the text</summary>
	public float MinimumDesiredWidth;
	///<summary>When set to true the caret is moved when gaining focus</summary>
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
	///<summary>Additional options for the virtual keyboard</summary>
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	///<summary>VirtualKeyboardTrigger</summary>
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
	public FOnEditableTextChangedEvent OnTextChanged;
	///<summary>Called whenever the text is committed.  This happens when the user presses enter or the text box loses focus.</summary>
	public FOnEditableTextCommittedEvent OnTextCommitted;
	///<summary>Gets the widget text</summary>
	public  string GetText() { return default; }
	///<summary>Directly sets the widget text.</summary>
	public  void SetText(string InText) {}
	///<summary>SetIsPassword</summary>
	public  void SetIsPassword(bool InbIsPassword) {}
	///<summary>Gets the Hint text that appears when there is no text in the text box</summary>
	public  string GetHintText() { return default; }
	///<summary>SetHintText</summary>
	public  void SetHintText(string InHintText) {}
	///<summary>Set the minimum desired width for this text box</summary>
	public  void SetMinimumDesiredWidth(float InMinDesiredWidth) {}
	///<summary>SetIsReadOnly</summary>
	public  void SetIsReadOnly(bool InbIsReadyOnly) {}
	///<summary>GetJustification</summary>
	public  ETextJustify GetJustification() { return default; }
	///<summary>SetJustification</summary>
	public  void SetJustification(ETextJustify InJustification) {}
	///<summary>SetTextOverflowPolicy</summary>
	public  void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	///<summary>GetFont</summary>
	public  FSlateFontInfo GetFont() { return default; }
	///<summary>SetFont</summary>
	public  void SetFont(FSlateFontInfo InFontInfo) {}
	///<summary>SetFontMaterial</summary>
	public  void SetFontMaterial(UMaterialInterface InMaterial) {}
	///<summary>SetFontOutlineMaterial</summary>
	public  void SetFontOutlineMaterial(UMaterialInterface InMaterial) {}
}

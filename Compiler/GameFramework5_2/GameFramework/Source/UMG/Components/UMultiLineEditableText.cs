#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/MultiLineEditableText.h")]
///<summary>Editable text box widget</summary>
public partial class UMultiLineEditableText : UTextLayoutWidget {
// MultiLineEditableText
	public  void FOnMultiLineEditableTextChangedEvent(string Text) {}
	public  void FOnMultiLineEditableTextCommittedEvent(string Text,ETextCommit CommitMethod) {}
	public string Text;
	public string HintText;
	public FGetText HintTextDelegate;
	public FTextBlockStyle WidgetStyle;
	public bool bIsReadOnly;
	public bool SelectAllTextWhenFocused;
	public bool ClearTextSelectionOnFocusLoss;
	public bool RevertTextOnEscape;
	public bool ClearKeyboardFocusOnCommit;
	public bool AllowContextMenu;
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	public FOnMultiLineEditableTextChangedEvent OnTextChanged;
	public FOnMultiLineEditableTextCommittedEvent OnTextCommitted;
	public  string GetText() { return default; }
	public  void SetText(string InText) {}
	public  string GetHintText() { return default; }
	public  void SetHintText(string InHintText) {}
	public  void SetIsReadOnly(bool bReadOnly) {}
	public  void SetWidgetStyle(FTextBlockStyle InWidgetStyle) {}
	public  FSlateFontInfo GetFont() { return default; }
	public  void SetFont(FSlateFontInfo InFontInfo) {}
	public  void SetFontMaterial(UMaterialInterface InMaterial) {}
	public  void SetFontOutlineMaterial(UMaterialInterface InMaterial) {}
}

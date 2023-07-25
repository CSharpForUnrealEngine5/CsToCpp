#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/EditableText.h")]
///<summary>Editable text box widget</summary>
public partial class UEditableText : UWidget {
// EditableText
	public void FOnEditableTextChangedEvent(string Text) {}
	public void FOnEditableTextCommittedEvent(string Text,ETextCommit CommitMethod) {}
	public string Text;
	public FGetText TextDelegate;
	public string HintText;
	public FGetText HintTextDelegate;
	public FEditableTextStyle WidgetStyle;
	public bool IsReadOnly;
	public bool IsPassword;
	public float MinimumDesiredWidth;
	public bool IsCaretMovedWhenGainFocus;
	public bool SelectAllTextWhenFocused;
	public bool RevertTextOnEscape;
	public bool ClearKeyboardFocusOnCommit;
	public bool SelectAllTextOnCommit;
	public bool AllowContextMenu;
	public byte KeyboardType;
	public FVirtualKeyboardOptions VirtualKeyboardOptions;
	public EVirtualKeyboardTrigger VirtualKeyboardTrigger;
	public EVirtualKeyboardDismissAction VirtualKeyboardDismissAction;
	public byte Justification;
	public ETextOverflowPolicy OverflowPolicy;
	public FShapedTextOptions ShapedTextOptions;
	public FOnEditableTextChangedEvent OnTextChanged;
	public FOnEditableTextCommittedEvent OnTextCommitted;
	public string GetText() { return default; }
	public void SetText(string InText) {}
	public void SetIsPassword(bool InbIsPassword) {}
	public string GetHintText() { return default; }
	public void SetHintText(string InHintText) {}
	public void SetMinimumDesiredWidth(float InMinDesiredWidth) {}
	public void SetIsReadOnly(bool InbIsReadyOnly) {}
	public ETextJustify GetJustification() { return default; }
	public void SetJustification(ETextJustify InJustification) {}
	public void SetTextOverflowPolicy(ETextOverflowPolicy InOverflowPolicy) {}
	public FSlateFontInfo GetFont() { return default; }
	public void SetFont(FSlateFontInfo InFontInfo) {}
	public void SetFontMaterial(UObject InMaterial) {}
	public void SetFontOutlineMaterial(UObject InMaterial) {}
}

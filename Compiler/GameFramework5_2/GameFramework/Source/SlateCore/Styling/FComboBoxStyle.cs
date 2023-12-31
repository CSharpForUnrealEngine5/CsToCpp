namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the appearance of an SComboBox</summary>
[CppInclude("Styling/SlateTypes.h")]
public partial struct FComboBoxStyle {
	public FComboButtonStyle ComboButtonStyle;
	public FSlateSound PressedSlateSound;
	public FSlateSound SelectionChangeSlateSound;
	public FMargin ContentPadding;
	public FMargin MenuRowPadding;
	public FName PressedSound_DEPRECATED;
	public FName SelectionChangeSound_DEPRECATED;
}

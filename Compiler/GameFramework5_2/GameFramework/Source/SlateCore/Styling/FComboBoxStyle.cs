#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateTypes.h")]
///<summary>Represents the appearance of an SComboBox</summary>
public partial struct FComboBoxStyle {
// ComboBoxStyle
	public FComboButtonStyle ComboButtonStyle;
	public FSlateSound PressedSlateSound;
	public FSlateSound SelectionChangeSlateSound;
	public FMargin ContentPadding;
	public FMargin MenuRowPadding;
	public string PressedSound_DEPRECATED;
	public string SelectionChangeSound_DEPRECATED;
}

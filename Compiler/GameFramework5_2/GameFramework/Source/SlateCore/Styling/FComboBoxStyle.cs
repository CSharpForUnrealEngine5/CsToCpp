#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	public string PressedSound_DEPRECATED;
	public string SelectionChangeSound_DEPRECATED;
}

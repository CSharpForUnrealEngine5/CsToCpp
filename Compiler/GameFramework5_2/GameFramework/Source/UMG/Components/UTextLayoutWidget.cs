#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TextWidgetTypes.h")]
///<summary>Base class for all widgets that use a text layout.</summary>
public partial class UTextLayoutWidget : UWidget {
// TextLayoutWidget
	public  void SetJustification(ETextJustify InJustification) {}
	public FShapedTextOptions ShapedTextOptions;
	public byte Justification;
	public ETextWrappingPolicy WrappingPolicy;
	public bool AutoWrapText;
	public float WrapTextAt;
	public FMargin Margin;
	public float LineHeightPercentage;
}

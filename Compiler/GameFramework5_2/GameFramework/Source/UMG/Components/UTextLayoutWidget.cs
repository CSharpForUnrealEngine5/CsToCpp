#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all widgets that use a text layout.</summary>
[CppInclude("Components/TextWidgetTypes.h")]
public partial class UTextLayoutWidget : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>SetJustification</summary>
	public  void SetJustification(ETextJustify InJustification) {}
	///<summary>Controls how the text within this widget should be shaped.</summary>
	public FShapedTextOptions ShapedTextOptions;
	///<summary>How the text should be aligned with the margin.</summary>
	public ETextJustify Justification;
	///<summary>The wrapping policy to use.</summary>
	public ETextWrappingPolicy WrappingPolicy;
	///<summary>True if we&#39;re wrapping text automatically based on the computed horizontal space for this widget.</summary>
	public bool AutoWrapText;
	///<summary>Whether text wraps onto a new line when it&#39;s length exceeds this width; if this value is zero or negative, no wrapping occurs.</summary>
	public float WrapTextAt;
	///<summary>The amount of blank space left around the edges of text area.</summary>
	public FMargin Margin;
	///<summary>The amount to scale each lines height by.</summary>
	public float LineHeightPercentage;
}

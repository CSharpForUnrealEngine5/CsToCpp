#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/SlateBrush.h")]
///<summary>Possible options for rounded box brush image</summary>
public partial struct FSlateBrushOutlineSettings {
// SlateBrushOutlineSettings
	public FVector4 CornerRadii;
	public FSlateColor Color;
	public float Width;
	public ESlateBrushRoundingType RoundingType;
	public bool bUseBrushTransparency;
}

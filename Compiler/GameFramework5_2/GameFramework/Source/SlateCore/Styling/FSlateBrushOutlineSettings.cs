namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Possible options for rounded box brush image</summary>
[CppInclude("Styling/SlateBrush.h")]
public partial struct FSlateBrushOutlineSettings {
	public FVector4 CornerRadii;
	public FSlateColor Color;
	public float Width;
	public ESlateBrushRoundingType RoundingType;
	public bool bUseBrushTransparency;
}

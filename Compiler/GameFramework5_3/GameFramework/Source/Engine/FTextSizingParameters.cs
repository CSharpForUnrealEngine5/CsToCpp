namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>General purpose data structure for grouping all parameters needed when sizing or wrapping a string</summary>
[CppInclude("CanvasTypes.h")]
public partial struct FTextSizingParameters {
	public float DrawX;
	public float DrawY;
	public float DrawXL;
	public float DrawYL;
	public FVector2D Scaling;
	public UFont DrawFont;
	public FVector2D SpacingAdjust;
}

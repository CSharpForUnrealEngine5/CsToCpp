#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CanvasTypes.h")]
///<summary>General purpose data structure for grouping all parameters needed when sizing or wrapping a string</summary>
public partial struct FTextSizingParameters {
// TextSizingParameters
	public float DrawX;
	public float DrawY;
	public float DrawXL;
	public float DrawYL;
	public FVector2D Scaling;
	public UFont DrawFont;
	public FVector2D SpacingAdjust;
}

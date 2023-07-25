#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionBumpOffset.h")]
public partial class UMaterialExpressionBumpOffset : UMaterialExpression {
// MaterialExpressionBumpOffset
	public FExpressionInput Coordinate;
	public FExpressionInput Height;
	public FExpressionInput HeightRatioInput;
	public float HeightRatio;
	public float ReferencePlane;
	public uint ConstCoordinate;
}

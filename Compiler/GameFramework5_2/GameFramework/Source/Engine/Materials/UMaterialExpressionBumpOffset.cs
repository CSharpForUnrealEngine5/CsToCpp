#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionBumpOffset.h")]
public partial class UMaterialExpressionBumpOffset : UMaterialExpression {
	///<summary>Defaults to &#39;ConstCoordinate&#39; if not specified</summary>
	public FExpressionInput Coordinate;
	///<summary>Height</summary>
	public FExpressionInput Height;
	///<summary>HeightRatioInput</summary>
	public FExpressionInput HeightRatioInput;
	///<summary>HeightRatio</summary>
	public float HeightRatio;
	///<summary>Perceived height as a fraction of width.</summary>
	public float ReferencePlane;
	///<summary>only used if Coordinate is not hooked up</summary>
	public uint ConstCoordinate;
}

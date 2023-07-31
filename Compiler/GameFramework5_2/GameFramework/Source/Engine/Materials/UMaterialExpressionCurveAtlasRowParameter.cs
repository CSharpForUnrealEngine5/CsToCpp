#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionCurveAtlasRowParameter.h")]
public partial class UMaterialExpressionCurveAtlasRowParameter : UMaterialExpressionScalarParameter {
	///<summary>Curve</summary>
	public UCurveLinearColor Curve;
	///<summary>Atlas</summary>
	public UCurveLinearColorAtlas Atlas;
	///<summary>InputTime</summary>
	public FExpressionInput InputTime;
}

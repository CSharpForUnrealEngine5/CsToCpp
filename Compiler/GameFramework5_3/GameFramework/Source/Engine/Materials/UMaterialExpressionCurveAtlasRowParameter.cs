namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionCurveAtlasRowParameter.h")]
public partial class UMaterialExpressionCurveAtlasRowParameter : UMaterialExpressionScalarParameter {
	public static UClass StaticClass() {return default;}
	///<summary>Curve</summary>
	public UCurveLinearColor Curve;
	///<summary>Atlas</summary>
	public UCurveLinearColorAtlas Atlas;
	///<summary>InputTime</summary>
	public FExpressionInput InputTime;
}

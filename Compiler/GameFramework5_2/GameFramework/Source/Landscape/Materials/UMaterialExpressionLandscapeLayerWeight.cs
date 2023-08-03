#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLandscapeLayerWeight.h")]
public partial class UMaterialExpressionLandscapeLayerWeight : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstBase&#39; if not specified</summary>
	public FExpressionInput Base;
	///<summary>Ignored if not specified</summary>
	public FExpressionInput Layer;
	///<summary>ParameterName</summary>
	public string ParameterName;
	///<summary>PreviewWeight</summary>
	public float PreviewWeight;
	///<summary>only used if Base is not hooked up</summary>
	public FVector ConstBase;
}

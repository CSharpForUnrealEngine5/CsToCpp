#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTransformPosition.h")]
public partial class UMaterialExpressionTransformPosition : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>input expression for this transform</summary>
	public FExpressionInput Input;
	///<summary>source format of the position that will be transformed</summary>
	public EMaterialPositionTransformSource TransformSourceType;
	///<summary>type of transform to apply to the input expression</summary>
	public EMaterialPositionTransformSource TransformType;
}

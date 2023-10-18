namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTransform.h")]
public partial class UMaterialExpressionTransform : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>input expression for this transform</summary>
	public FExpressionInput Input;
	///<summary>Source coordinate space of the FVector</summary>
	public EMaterialVectorCoordTransformSource TransformSourceType;
	///<summary>Destination coordinate space of the FVector</summary>
	public EMaterialVectorCoordTransform TransformType;
}

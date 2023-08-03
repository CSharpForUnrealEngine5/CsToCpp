#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionConstantBiasScale.h")]
public partial class UMaterialExpressionConstantBiasScale : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>Bias</summary>
	public float Bias;
	///<summary>Scale</summary>
	public float Scale;
}

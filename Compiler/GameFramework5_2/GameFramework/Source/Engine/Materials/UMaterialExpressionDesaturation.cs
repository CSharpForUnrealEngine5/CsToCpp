namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDesaturation.h")]
public partial class UMaterialExpressionDesaturation : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Outputs: Lerp(Input,dot(Input,LuminanceFactors)),Fraction)</summary>
	public FExpressionInput Input;
	///<summary>Fraction</summary>
	public FExpressionInput Fraction;
	///<summary>LuminanceFactors</summary>
	public FLinearColor LuminanceFactors;
}

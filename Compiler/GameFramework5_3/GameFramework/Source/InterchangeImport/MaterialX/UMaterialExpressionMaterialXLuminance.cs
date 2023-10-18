namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressions/MaterialExpressionLuminance.h")]
public partial class UMaterialExpressionMaterialXLuminance : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>LuminanceFactors</summary>
	public FLinearColor LuminanceFactors;
	///<summary>Color component factors for converting a color to greyscale.</summary>
	public EMaterialXLuminanceMode LuminanceMode;
}

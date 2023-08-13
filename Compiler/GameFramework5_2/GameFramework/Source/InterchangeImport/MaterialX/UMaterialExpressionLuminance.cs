namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionLuminance.h")]
public partial class UMaterialExpressionLuminance : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>LuminanceFactors</summary>
	public FLinearColor LuminanceFactors;
	///<summary>Color component factors for converting a color to greyscale.</summary>
	public ELuminanceMode LuminanceMode;
}

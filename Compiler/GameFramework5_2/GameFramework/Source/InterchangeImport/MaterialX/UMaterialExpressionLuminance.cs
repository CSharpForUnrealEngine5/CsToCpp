#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialX/MaterialExpressionLuminance.h")]
public partial class UMaterialExpressionLuminance : UMaterialExpression {
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>LuminanceFactors</summary>
	public FLinearColor LuminanceFactors;
	///<summary>Color component factors for converting a color to greyscale.</summary>
	public ELuminanceMode LuminanceMode;
}

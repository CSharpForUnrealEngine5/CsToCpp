namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionHairColor.h")]
public partial class UMaterialExpressionHairColor : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Control the concentration of melanin in hair. Value is normalize over the plausible range of human hair.</summary>
	public FExpressionInput Melanin;
	///<summary>Control the redness tint of the hair. Value is normalize over the plausible range of human hair.</summary>
	public FExpressionInput Redness;
	///<summary>Control the dyeing color of the hair. By default there is no dyeing color.</summary>
	public FExpressionInput DyeColor;
}

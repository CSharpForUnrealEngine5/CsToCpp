namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Provides access to the EyeAdaptation render target.</summary>
[CppInclude("Materials/MaterialExpressionEyeAdaptationInverse.h")]
public partial class UMaterialExpressionEyeAdaptationInverse : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Value to apply EyeAdaptation inverse</summary>
	public FExpressionInput LightValueInput;
	///<summary>Weight of the conversion. 1.0 means full conversion, 0.0 means no change.</summary>
	public FExpressionInput AlphaInput;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionShadingPathSwitch.h")]
public partial class UMaterialExpressionShadingPathSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Default connection, used when a specific shading type input is missing.</summary>
	public FExpressionInput Default;
	///<summary>Inputs</summary>
	public FExpressionInput Inputs;
}

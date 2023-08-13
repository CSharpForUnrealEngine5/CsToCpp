namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionQualitySwitch.h")]
public partial class UMaterialExpressionQualitySwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Default connection, used when a specific quality level input is missing.</summary>
	public FExpressionInput Default;
	///<summary>Inputs</summary>
	public FExpressionInput Inputs;
}

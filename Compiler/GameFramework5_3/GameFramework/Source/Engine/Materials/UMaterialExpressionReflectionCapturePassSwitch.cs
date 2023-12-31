namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionReflectionCapturePassSwitch.h")]
public partial class UMaterialExpressionReflectionCapturePassSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input will be used when rendering into non-reflection passes.</summary>
	public FExpressionInput Default;
	///<summary>Input will be used when rendering into reflection passes.</summary>
	public FExpressionInput Reflection;
}

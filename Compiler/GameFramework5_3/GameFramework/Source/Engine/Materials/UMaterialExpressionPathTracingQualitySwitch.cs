namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPathTracingQualitySwitch.h")]
public partial class UMaterialExpressionPathTracingQualitySwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Used for non-path traced modes</summary>
	public FExpressionInput Normal;
	///<summary>Used by the path tracer</summary>
	public FExpressionInput PathTraced;
}

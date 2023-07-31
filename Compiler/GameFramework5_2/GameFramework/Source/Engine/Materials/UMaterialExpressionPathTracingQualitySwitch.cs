#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPathTracingQualitySwitch.h")]
public partial class UMaterialExpressionPathTracingQualitySwitch : UMaterialExpression {
	///<summary>Used for non-path traced modes</summary>
	public FExpressionInput Normal;
	///<summary>Used by the path tracer</summary>
	public FExpressionInput PathTraced;
}

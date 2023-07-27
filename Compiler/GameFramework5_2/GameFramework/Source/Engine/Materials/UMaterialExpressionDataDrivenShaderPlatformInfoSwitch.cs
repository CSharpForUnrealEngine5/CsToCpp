#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDataDrivenShaderPlatformInfoSwitch.h")]
public partial class UMaterialExpressionDataDrivenShaderPlatformInfoSwitch : UMaterialExpression {
// MaterialExpressionDataDrivenShaderPlatformInfoSwitch
	public FExpressionInput InputTrue;
	public FExpressionInput InputFalse;
	public TArray<FDataDrivenShaderPlatformInfoInput> DDSPIPropertyNames;
	public  TArray<string> GetNameOptions() { return default; }
	public bool bContainsInvalidProperty;
}

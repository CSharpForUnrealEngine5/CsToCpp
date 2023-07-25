#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionCustom.h")]
public partial class UMaterialExpressionCustom : UMaterialExpression {
// MaterialExpressionCustom
	public string Code;
	public byte OutputType;
	public string Description;
	public TArray<FCustomInput> Inputs;
	public TArray<FCustomOutput> AdditionalOutputs;
	public TArray<FCustomDefine> AdditionalDefines;
	public TArray<string> IncludeFilePaths;
}

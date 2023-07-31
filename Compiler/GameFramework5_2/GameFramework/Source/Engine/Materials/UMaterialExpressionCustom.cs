#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionCustom.h")]
public partial class UMaterialExpressionCustom : UMaterialExpression {
	///<summary>Code</summary>
	public string Code;
	///<summary>OutputType</summary>
	public ECustomMaterialOutputType OutputType;
	///<summary>Description</summary>
	public string Description;
	///<summary>Inputs</summary>
	public TArray<FCustomInput> Inputs;
	///<summary>AdditionalOutputs</summary>
	public TArray<FCustomOutput> AdditionalOutputs;
	///<summary>AdditionalDefines</summary>
	public TArray<FCustomDefine> AdditionalDefines;
	///<summary>IncludeFilePaths</summary>
	public TArray<string> IncludeFilePaths;
}

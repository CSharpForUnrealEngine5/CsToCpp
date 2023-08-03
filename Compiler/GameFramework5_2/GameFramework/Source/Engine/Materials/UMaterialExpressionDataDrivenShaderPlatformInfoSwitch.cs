#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDataDrivenShaderPlatformInfoSwitch.h")]
public partial class UMaterialExpressionDataDrivenShaderPlatformInfoSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>InputTrue</summary>
	public FExpressionInput InputTrue;
	///<summary>InputFalse</summary>
	public FExpressionInput InputFalse;
	///<summary>DDSPIPropertyNames</summary>
	public TArray<FDataDrivenShaderPlatformInfoInput> DDSPIPropertyNames;
	///<summary>GetNameOptions</summary>
	public  TArray<string> GetNameOptions() { return default; }
	///<summary>bContainsInvalidProperty</summary>
	public bool bContainsInvalidProperty;
}

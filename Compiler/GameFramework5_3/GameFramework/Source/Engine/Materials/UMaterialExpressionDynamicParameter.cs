namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionDynamicParameter.h")]
public partial class UMaterialExpressionDynamicParameter : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>The names of the parameters.</summary>
	public TArray<string> ParamNames;
	///<summary>DefaultValue</summary>
	public FLinearColor DefaultValue;
	///<summary>The index of the dynamic parameter for use in tools that allow &gt; 1</summary>
	public uint ParameterIndex;
}

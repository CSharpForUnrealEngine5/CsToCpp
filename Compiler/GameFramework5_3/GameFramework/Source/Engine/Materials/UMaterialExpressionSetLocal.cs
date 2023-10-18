namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSetLocal.h")]
public partial class UMaterialExpressionSetLocal : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Exec</summary>
	public FExpressionExecOutput Exec;
	///<summary>Value</summary>
	public FExpressionInput Value;
	///<summary>LocalName</summary>
	public FName LocalName;
}

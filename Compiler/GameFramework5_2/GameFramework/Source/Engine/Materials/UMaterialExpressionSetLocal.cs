#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
	public string LocalName;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionBlackBody.h")]
public partial class UMaterialExpressionBlackBody : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Temperature</summary>
	public FExpressionInput Temp;
}

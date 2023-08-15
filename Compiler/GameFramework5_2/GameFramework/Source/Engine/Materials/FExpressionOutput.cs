namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that represents an expression&#39;s output.</summary>
[CppInclude("Materials/MaterialExpression.h")]
public partial struct FExpressionOutput {
	public FName OutputName;
	public int Mask;
	public int MaskR;
	public int MaskG;
	public int MaskB;
	public int MaskA;
}

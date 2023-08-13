namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This node type acts like a collapsed node, a single node that represents</summary>
[CppInclude("K2Node_MathExpression.h")]
public partial class UK2Node_MathExpression : UK2Node_Composite {
	public static UClass StaticClass() {return default;}
	///<summary>The math expression to evaluate</summary>
	public string Expression;
	///<summary>bMadeAfterRotChange</summary>
	public bool bMadeAfterRotChange;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The promotable operator node allows for pin types to be promoted to others, i.e. float to double</summary>
[CppInclude("K2Node_PromotableOperator.h")]
public partial class UK2Node_PromotableOperator : UK2Node_CallFunction {
	public static UClass StaticClass() {return default;}
	///<summary>The current number of additional pins on this node</summary>
	public int NumAdditionalInputs;
}

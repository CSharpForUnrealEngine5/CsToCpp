namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPreviousFrameSwitch.h")]
public partial class UMaterialExpressionPreviousFrameSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>CurrentFrame</summary>
	public FExpressionInput CurrentFrame;
	///<summary>PreviousFrame</summary>
	public FExpressionInput PreviousFrame;
}

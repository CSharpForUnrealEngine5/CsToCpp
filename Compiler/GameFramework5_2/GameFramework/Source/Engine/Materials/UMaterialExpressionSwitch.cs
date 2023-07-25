#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSwitch.h")]
public partial class UMaterialExpressionSwitch : UMaterialExpression {
// MaterialExpressionSwitch
	public string Description;
	public FExpressionInput SwitchValue;
	public float ConstSwitchValue;
	public FExpressionInput Default;
	public float ConstDefault;
	public TArray<FSwitchCustomInput> Inputs;
}

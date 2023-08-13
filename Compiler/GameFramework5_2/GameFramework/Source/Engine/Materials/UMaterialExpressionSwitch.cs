namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSwitch.h")]
public partial class UMaterialExpressionSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Description</summary>
	public string Description;
	///<summary>Defaults to &#39;ConstSwitchValue&#39; if not specified</summary>
	public FExpressionInput SwitchValue;
	///<summary>only used if Selector is not hooked up</summary>
	public float ConstSwitchValue;
	///<summary>Defaults to &#39;ConstDefault&#39; if not specified</summary>
	public FExpressionInput Default;
	///<summary>only used if Selector is not hooked up</summary>
	public float ConstDefault;
	///<summary>Inputs</summary>
	public TArray<FSwitchCustomInput> Inputs;
}

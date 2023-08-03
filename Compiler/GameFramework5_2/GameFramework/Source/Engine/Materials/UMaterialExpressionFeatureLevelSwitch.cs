#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionFeatureLevelSwitch.h")]
public partial class UMaterialExpressionFeatureLevelSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Default connection, used when a certain feature level doesn&#39;t have an override.</summary>
	public FExpressionInput Default;
	///<summary>Inputs</summary>
	public FExpressionInput Inputs;
}

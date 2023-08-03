#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionStaticSwitch.h")]
public partial class UMaterialExpressionStaticSwitch : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>DefaultValue</summary>
	public bool DefaultValue;
	///<summary>A</summary>
	public FExpressionInput A;
	///<summary>B</summary>
	public FExpressionInput B;
	///<summary>Ignored if not specified</summary>
	public FExpressionInput Value;
}

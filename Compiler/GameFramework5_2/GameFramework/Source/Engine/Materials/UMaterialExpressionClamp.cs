#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionClamp.h")]
public partial class UMaterialExpressionClamp : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>Defaults to &#39;MinDefault&#39; if not specified</summary>
	public FExpressionInput Min;
	///<summary>Defaults to &#39;MaxDefault&#39; if not specified</summary>
	public FExpressionInput Max;
	///<summary>ClampMode</summary>
	public EClampMode ClampMode;
	///<summary>MinDefault</summary>
	public float MinDefault;
	///<summary>MaxDefault</summary>
	public float MaxDefault;
}

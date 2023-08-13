namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A material expression that Remap a value from one range to another.</summary>
[CppInclude("MaterialX/MaterialExpressionRemap.h")]
public partial class UMaterialExpressionRemap : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Input</summary>
	public FExpressionInput Input;
	///<summary>Defaults to &#39;MinDefault1&#39; if not specified</summary>
	public FExpressionInput InputLow;
	///<summary>Defaults to &#39;MaxDefault1&#39; if not specified</summary>
	public FExpressionInput InputHigh;
	///<summary>Defaults to &#39;MinDefault2&#39; if not specified</summary>
	public FExpressionInput TargetLow;
	///<summary>Defaults to &#39;MaxDefault1&#39; if not specified</summary>
	public FExpressionInput TargetHigh;
	///<summary>InputLowDefault</summary>
	public float InputLowDefault;
	///<summary>InputHighDefault</summary>
	public float InputHighDefault;
	///<summary>TargetLowDefault</summary>
	public float TargetLowDefault;
	///<summary>TargetHighDefault</summary>
	public float TargetHighDefault;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Merge nodes take two 4-channel (color4) inputs and use the built-in alpha channel(s) to control the</summary>
[CppInclude("MaterialX/MaterialExpressionMask.h")]
public partial class UMaterialExpressionMask : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>A</summary>
	public FExpressionInput A;
	///<summary>B</summary>
	public FExpressionInput B;
	///<summary>Defaults to &#39;ConstAlpha&#39; if not specified</summary>
	public FExpressionInput Alpha;
	///<summary>only used if Alpha is not hooked up</summary>
	public float ConstAlpha;
}

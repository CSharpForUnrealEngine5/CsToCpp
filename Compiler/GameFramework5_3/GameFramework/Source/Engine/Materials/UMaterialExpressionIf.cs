namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionIf.h")]
public partial class UMaterialExpressionIf : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>A</summary>
	public FExpressionInput A;
	///<summary>Defaults to &#39;ConstB&#39; if not specified</summary>
	public FExpressionInput B;
	///<summary>AGreaterThanB</summary>
	public FExpressionInput AGreaterThanB;
	///<summary>Defaults to &#39;A &gt; B&#39; if not specified</summary>
	public FExpressionInput AEqualsB;
	///<summary>ALessThanB</summary>
	public FExpressionInput ALessThanB;
	///<summary>EqualsThreshold</summary>
	public float EqualsThreshold;
	///<summary>only used if B is not hooked up</summary>
	public float ConstB;
	///<summary>ConstAEqualsB_DEPRECATED</summary>
	public float ConstAEqualsB_DEPRECATED;
}

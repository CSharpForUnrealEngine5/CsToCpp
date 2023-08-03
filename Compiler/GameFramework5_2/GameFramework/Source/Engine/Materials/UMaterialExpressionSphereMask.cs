#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionSphereMask.h")]
public partial class UMaterialExpressionSphereMask : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>1 to 4 dimensional vector, should be the same type as B</summary>
	public FExpressionInput A;
	///<summary>1 to 4 dimensional vector, should be the same type as A</summary>
	public FExpressionInput B;
	///<summary>Defaults to &#39;AttenuationRadius&#39; if not specified</summary>
	public FExpressionInput Radius;
	///<summary>Defaults to &#39;HardnessPercent&#39; if not specified</summary>
	public FExpressionInput Hardness;
	///<summary>in the unit that A and B are measured</summary>
	public float AttenuationRadius;
	///<summary>in percent 0%=soft .. 100%=hard</summary>
	public float HardnessPercent;
}

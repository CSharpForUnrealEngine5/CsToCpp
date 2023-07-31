#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionTime.h")]
public partial class UMaterialExpressionTime : UMaterialExpression {
	///<summary>This time continues advancing regardless of whether the game is paused.</summary>
	public bool bIgnorePause;
	///<summary>Enables or disables the Period value.</summary>
	public bool bOverride_Period;
	///<summary>Period at which to wrap around time</summary>
	public float Period;
}

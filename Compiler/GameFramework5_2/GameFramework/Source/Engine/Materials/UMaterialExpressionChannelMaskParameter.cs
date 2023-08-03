#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionChannelMaskParameter.h")]
public partial class UMaterialExpressionChannelMaskParameter : UMaterialExpressionVectorParameter {
	public static UClass StaticClass() {return default;}
	///<summary>MaskChannel</summary>
	public EChannelMaskParameterColor MaskChannel;
	///<summary>Input</summary>
	public FExpressionInput Input;
}

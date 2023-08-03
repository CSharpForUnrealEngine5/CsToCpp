#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionPerInstanceCustomData.h")]
public partial class UMaterialExpressionPerInstanceCustomData : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to &#39;ConstDefaultValue&#39; if not specified; Default value is used when no instances provided.</summary>
	public FExpressionInput DefaultValue;
	///<summary>ConstDefaultValue</summary>
	public float ConstDefaultValue;
	///<summary>DataIndex</summary>
	public uint DataIndex;
}

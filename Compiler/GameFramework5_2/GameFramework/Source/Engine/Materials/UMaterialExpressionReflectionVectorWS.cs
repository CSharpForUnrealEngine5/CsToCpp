#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionReflectionVectorWS.h")]
public partial class UMaterialExpressionReflectionVectorWS : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Defaults to Reflection Vector if not specified</summary>
	public FExpressionInput CustomWorldNormal;
	///<summary>(true): The specified world normal will be normalized. (false): WorldNormal will just be used as is, faster but possible artifacts if normal length isn&#39;t 1</summary>
	public bool bNormalizeCustomWorldNormal;
}

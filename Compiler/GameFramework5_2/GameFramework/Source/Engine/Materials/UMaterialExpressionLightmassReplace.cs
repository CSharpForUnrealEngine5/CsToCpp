namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLightmassReplace.h")]
public partial class UMaterialExpressionLightmassReplace : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Realtime</summary>
	public FExpressionInput Realtime;
	///<summary>Lightmass</summary>
	public FExpressionInput Lightmass;
}

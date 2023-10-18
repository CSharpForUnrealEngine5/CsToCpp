namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionLandscapeLayerBlend.h")]
public partial class UMaterialExpressionLandscapeLayerBlend : UMaterialExpression {
	public static UClass StaticClass() {return default;}
	///<summary>Layers</summary>
	public TArray<FLayerBlendInput> Layers;
}

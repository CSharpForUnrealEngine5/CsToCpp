#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionMaterialAttributeLayers.h")]
public partial class UMaterialExpressionMaterialAttributeLayers : UMaterialExpression {
// MaterialExpressionMaterialAttributeLayers
	public FMaterialAttributesInput Input;
	public FMaterialLayersFunctions DefaultLayers;
	public TArray<UMaterialExpressionMaterialFunctionCall> LayerCallers;
	public int NumActiveLayerCallers;
	public TArray<UMaterialExpressionMaterialFunctionCall> BlendCallers;
	public int NumActiveBlendCallers;
	public bool bIsLayerGraphBuilt;
}

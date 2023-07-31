#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionMaterialAttributeLayers.h")]
public partial class UMaterialExpressionMaterialAttributeLayers : UMaterialExpression {
	///<summary>Input</summary>
	public FMaterialAttributesInput Input;
	///<summary>DefaultLayers</summary>
	public FMaterialLayersFunctions DefaultLayers;
	///<summary>LayerCallers</summary>
	public TArray<UMaterialExpressionMaterialFunctionCall> LayerCallers;
	///<summary>NumActiveLayerCallers</summary>
	public int NumActiveLayerCallers;
	///<summary>BlendCallers</summary>
	public TArray<UMaterialExpressionMaterialFunctionCall> BlendCallers;
	///<summary>NumActiveBlendCallers</summary>
	public int NumActiveBlendCallers;
	///<summary>bIsLayerGraphBuilt</summary>
	public bool bIsLayerGraphBuilt;
}

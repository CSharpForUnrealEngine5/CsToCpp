namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionMaterialAttributeLayers.h")]
public partial class UMaterialExpressionMaterialAttributeLayers : UMaterialExpression {
	public static UClass StaticClass() {return default;}
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

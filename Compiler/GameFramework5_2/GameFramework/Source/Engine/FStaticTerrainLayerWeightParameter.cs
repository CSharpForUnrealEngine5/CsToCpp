#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticParameterSet.h")]
///<summary>Stores information that maps a terrain layer to a particular weightmap index</summary>
public partial struct FStaticTerrainLayerWeightParameter {
// StaticTerrainLayerWeightParameter
	public FMaterialParameterInfo ParameterInfo_DEPRECATED;
	public FGuid ExpressionGUID_DEPRECATED;
	public bool bOverride_DEPRECATED;
	public string LayerName;
	public int WeightmapIndex;
	public bool bWeightBasedBlend;
}

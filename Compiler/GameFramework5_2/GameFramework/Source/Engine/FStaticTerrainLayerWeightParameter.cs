#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores information that maps a terrain layer to a particular weightmap index</summary>
[CppInclude("StaticParameterSet.h")]
public partial struct FStaticTerrainLayerWeightParameter {
	public FMaterialParameterInfo ParameterInfo_DEPRECATED;
	public FGuid ExpressionGUID_DEPRECATED;
	public bool bOverride_DEPRECATED;
	public string LayerName;
	public int WeightmapIndex;
	public bool bWeightBasedBlend;
}

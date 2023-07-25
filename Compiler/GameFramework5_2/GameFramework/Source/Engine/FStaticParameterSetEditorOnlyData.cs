#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticParameterSet.h")]
public partial struct FStaticParameterSetEditorOnlyData {
// StaticParameterSetEditorOnlyData
	public TArray<FStaticSwitchParameter> StaticSwitchParameters_DEPRECATED;
	public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters;
	public TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
	public FMaterialLayersFunctionsEditorOnlyData MaterialLayers;
}

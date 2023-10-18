namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticParameterSet.h")]
public partial struct FStaticParameterSetEditorOnlyData {
	public TArray<FStaticSwitchParameter> StaticSwitchParameters_DEPRECATED;
	public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters;
	public TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters;
	public FMaterialLayersFunctionsEditorOnlyData MaterialLayers;
}

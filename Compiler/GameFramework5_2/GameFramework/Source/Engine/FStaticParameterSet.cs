#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StaticParameterSet.h")]
///<summary>Contains all the information needed to identify a single permutation of static parameters.</summary>
public partial struct FStaticParameterSet {
// StaticParameterSet
	public FStaticParameterSetEditorOnlyData EditorOnly;
	public TArray<FStaticMaterialLayersParameter> MaterialLayersParameters_DEPRECATED;
	public TArray<FStaticSwitchParameter> StaticSwitchParameters_DEPRECATED;
	public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters_DEPRECATED;
	public TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters_DEPRECATED;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains all the information needed to identify a single permutation of static parameters.</summary>
[CppInclude("StaticParameterSet.h")]
public partial struct FStaticParameterSet {
	public FStaticParameterSetEditorOnlyData EditorOnly;
	public TArray<FStaticMaterialLayersParameter> MaterialLayersParameters_DEPRECATED;
	public TArray<FStaticSwitchParameter> StaticSwitchParameters_DEPRECATED;
	public TArray<FStaticComponentMaskParameter> StaticComponentMaskParameters_DEPRECATED;
	public TArray<FStaticTerrainLayerWeightParameter> TerrainLayerWeightParameters_DEPRECATED;
}

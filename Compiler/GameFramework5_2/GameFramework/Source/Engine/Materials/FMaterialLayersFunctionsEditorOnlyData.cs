namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialLayersFunctions.h")]
public partial struct FMaterialLayersFunctionsEditorOnlyData {
	public TArray<bool> LayerStates;
	public TArray<FText> LayerNames;
	public TArray<bool> RestrictToLayerRelatives;
	public TArray<bool> RestrictToBlendRelatives;
	public TArray<FGuid> LayerGuids;
	public TArray<EMaterialLayerLinkState> LayerLinkStates;
	public TArray<FGuid> DeletedParentLayerGuids;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
public partial struct FWaterBodyRiverDefaults {
	public FWaterBrushActorDefaults BrushDefaults;
	public TSoftObjectPtr<UMaterialInterface> RiverToOceanTransitionMaterial;
	public TSoftObjectPtr<UMaterialInterface> RiverToLakeTransitionMaterial;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
public partial struct FWaterBodyRiverDefaults {
// WaterBodyRiverDefaults
	public FWaterBrushActorDefaults BrushDefaults;
	public TSoftObjectPtr<UMaterialInterface> RiverToOceanTransitionMaterial;
	public TSoftObjectPtr<UMaterialInterface> RiverToLakeTransitionMaterial;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
public partial struct FWaterBodyDefaults {
// WaterBodyDefaults
	public FWaterSplineCurveDefaults SplineDefaults;
	public TSoftObjectPtr<UMaterialInterface> WaterMaterial;
	public TSoftObjectPtr<UMaterialInterface> WaterHLODMaterial;
	public TSoftObjectPtr<UMaterialInterface> UnderwaterPostProcessMaterial;
}

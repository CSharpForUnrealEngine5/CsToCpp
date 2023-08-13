namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
public partial struct FWaterBodyDefaults {
	public FWaterSplineCurveDefaults SplineDefaults;
	public TSoftObjectPtr<UMaterialInterface> WaterMaterial;
	public TSoftObjectPtr<UMaterialInterface> WaterHLODMaterial;
	public TSoftObjectPtr<UMaterialInterface> UnderwaterPostProcessMaterial;
}

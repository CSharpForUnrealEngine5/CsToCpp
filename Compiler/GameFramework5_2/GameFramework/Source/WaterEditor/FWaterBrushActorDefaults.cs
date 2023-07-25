#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
public partial struct FWaterBrushActorDefaults {
// WaterBrushActorDefaults
	public FWaterCurveSettings CurveSettings;
	public FWaterBodyHeightmapSettings HeightmapSettings;
	public TMap<string,FWaterBodyWeightmapSettings> LayerWeightmapSettings;
}

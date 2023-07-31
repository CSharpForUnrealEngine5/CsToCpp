#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
public partial struct FWaterBrushActorDefaults {
	public FWaterCurveSettings CurveSettings;
	public FWaterBodyHeightmapSettings HeightmapSettings;
	public TMap<string,FWaterBodyWeightmapSettings> LayerWeightmapSettings;
}

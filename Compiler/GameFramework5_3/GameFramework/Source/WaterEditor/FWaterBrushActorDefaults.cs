namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSettings.h")]
public partial struct FWaterBrushActorDefaults {
	public FWaterCurveSettings CurveSettings;
	public FWaterBodyHeightmapSettings HeightmapSettings;
	public TMap<FName,FWaterBodyWeightmapSettings> LayerWeightmapSettings;
}

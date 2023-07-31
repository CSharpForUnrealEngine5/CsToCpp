#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TerrainCarvingSettings.h")]
public partial struct FLandmassTerrainCarvingSettings {
	public EBrushBlendType BlendMode;
	public bool bInvertShape;
	public FLandmassFalloffSettings FalloffSettings;
	public FLandmassBrushEffectsList Effects;
	public int Priority;
}

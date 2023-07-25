#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ColorCorrectRegion.h")]
///<summary>An instance of Color Correction Region. Used to aggregate all active regions.</summary>
public partial class AColorCorrectRegion : AActor {
// ColorCorrectRegion
	public EColorCorrectRegionsType Type;
	public int Priority;
	public float Intensity;
	public float Inner;
	public float Outer;
	public float Falloff;
	public bool Invert;
	public EColorCorrectRegionTemperatureType TemperatureType;
	public float Temperature;
	public float Tint;
	public FColorGradingSettings ColorGradingSettings;
	public bool Enabled;
	public bool bEnablePerActorCC;
	public EColorCorrectRegionStencilType PerActorColorCorrection;
	public TSet<TSoftObjectPtr<AActor>> AffectedActors;
	public UBillboardComponent SpriteComponent;
	public UColorCorrectionInvisibleComponent IdentityComponent;
}

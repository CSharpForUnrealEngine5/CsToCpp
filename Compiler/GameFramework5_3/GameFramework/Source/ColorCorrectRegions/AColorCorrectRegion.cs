namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An instance of Color Correction Region. Used to aggregate all active regions.</summary>
[CppInclude("ColorCorrectRegion.h")]
public partial class AColorCorrectRegion : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Region type.</summary>
	public EColorCorrectRegionsType Type;
	///<summary>Render priority/order. The higher the number the later region will be applied.</summary>
	public int Priority;
	///<summary>Color correction intensity. Clamped to 0-1 range.</summary>
	public float Intensity;
	///<summary>Inner of the region. Swapped with Outer in case it is higher than Outer.</summary>
	public float Inner;
	///<summary>Outer of the region.</summary>
	public float Outer;
	///<summary>Falloff. Softening the region.</summary>
	public float Falloff;
	///<summary>Invert region.</summary>
	public bool Invert;
	///<summary>Type of algorithm to be used to control color temperature or white balance.</summary>
	public EColorCorrectRegionTemperatureType TemperatureType;
	///<summary>Color correction temperature.</summary>
	public float Temperature;
	///<summary>Color temperature tint.</summary>
	public float Tint;
	///<summary>Color correction settings.</summary>
	public FColorGradingSettings ColorGradingSettings;
	///<summary>Enable/Disable color correction provided by this region.</summary>
	public bool Enabled;
	///<summary>Enables or disabled per actor color correction.</summary>
	public bool bEnablePerActorCC;
	///<summary>Controls in which way the below targets will be affected by color correction.</summary>
	public EColorCorrectRegionStencilType PerActorColorCorrection;
	///<summary>List of actors that get affected or ignored by Per actor CC. Effect depends on the above option.</summary>
	public TSet<TSoftObjectPtr<AActor>> AffectedActors;
	///<summary>Billboard component for this actor.</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>The main purpose of this component is to determine the visibility status of this Color Correction Actor.</summary>
	public UColorCorrectionInvisibleComponent IdentityComponent;
}

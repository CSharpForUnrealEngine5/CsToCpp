namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/LocalHeightFogComponent.h")]
public partial class ULocalHeightFogComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Controls the softness of the transition region when the volume is fading out.</summary>
	public ELocalFogMode FogMode;
	///<summary>Global density factor for this fog.</summary>
	public float FogDensity;
	///<summary>Controls how the density decreases as height increases. Smaller values make the visible transition larger.</summary>
	public float FogHeightFalloff;
	///<summary>Height offset, relative to the actor Z position.</summary>
	public float FogHeightOffset;
	///<summary>Controls how strong the radial attenuation of this fog volume is.</summary>
	public float FogRadialAttenuation;
	///<summary>Controls the phase `G` parameter, describing the directionality of the scattering within this fog volume.</summary>
	public float FogPhaseG;
	///<summary>Controls the albedo of this fog volume.</summary>
	public FLinearColor FogAlbedo;
	///<summary>Controls the emissive color of this fog volume.</summary>
	public FLinearColor FogEmissive;
	///<summary>The priority can be used as a way to override the sorting by distance. A lower value means the volume will be considered further away, i.e. it will draw behind the one with a higher priority value.</summary>
	public int FogSortPriority;
}

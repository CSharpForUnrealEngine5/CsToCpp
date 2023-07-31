#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* OculusAudio material components are used to set the acoustic properties of the geometry.</summary>
[CppInclude("OculusAudioMaterialComponent.h")]
public partial class UOculusAudioMaterialComponent : UActorComponent {
	///<summary>Choose from a variety of preset physical materials, or choose Custom to specify values manually.</summary>
	public EOculusAudioMaterial MaterialPreset;
	///<summary>How much this material absorbs @ 63Hz</summary>
	public float Absorption63Hz;
	///<summary>How much this material absorbs @ 125Hz</summary>
	public float Absorption125Hz;
	///<summary>How much this material absorbs @ 250Hz</summary>
	public float Absorption250Hz;
	///<summary>How much this material absorbs @ 500Hz</summary>
	public float Absorption500Hz;
	///<summary>How much this material absorbs @ 1000Hz</summary>
	public float Absorption1000Hz;
	///<summary>How much this material absorbs @ 2000Hz</summary>
	public float Absorption2000Hz;
	///<summary>How much this material absorbs @ 4000Hz</summary>
	public float Absorption4000Hz;
	///<summary>How much this material absorbs @ 8000Hz</summary>
	public float Absorption8000Hz;
	///<summary>How much this material transmits @ 63Hz</summary>
	public float Transmission63Hz;
	///<summary>How much this material transmits @ 125Hz</summary>
	public float Transmission125Hz;
	///<summary>How much this material transmits @ 250Hz</summary>
	public float Transmission250Hz;
	///<summary>How much this material transmits @ 500Hz</summary>
	public float Transmission500Hz;
	///<summary>How much this material transmits @ 1000Hz</summary>
	public float Transmission1000Hz;
	///<summary>How much this material transmits @ 2000Hz</summary>
	public float Transmission2000Hz;
	///<summary>How much this material transmits @ 4000Hz</summary>
	public float Transmission4000Hz;
	///<summary>How much this material transmits @ 8000Hz</summary>
	public float Transmission8000Hz;
	///<summary>How much this material scatters @ 63Hz</summary>
	public float Scattering63Hz;
	///<summary>How much this material scatters @ 125Hz</summary>
	public float Scattering125Hz;
	///<summary>How much this material scatters @ 250Hz</summary>
	public float Scattering250Hz;
	///<summary>How much this material scatters @ 500Hz</summary>
	public float Scattering500Hz;
	///<summary>How much this material scatters @ 1000Hz</summary>
	public float Scattering1000Hz;
	///<summary>How much this material scatters @ 2000Hz</summary>
	public float Scattering2000Hz;
	///<summary>How much this material scatters @ 4000Hz</summary>
	public float Scattering4000Hz;
	///<summary>How much this material scatters @ 8000Hz</summary>
	public float Scattering8000Hz;
}

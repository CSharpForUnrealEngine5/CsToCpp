#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Phonon Material components are used to customize an actor&#39;s acoustic properties. Only valid on actors that also</summary>
[CppInclude("PhononMaterialComponent.h")]
public partial class UPhononMaterialComponent : UActorComponent {
	///<summary>MaterialIndex</summary>
	public int MaterialIndex;
	///<summary>Choose from a variety of preset physical materials, or choose Custom to specify values manually.</summary>
	public EPhononMaterial MaterialPreset;
	///<summary>How much this material absorbs low frequency sound.</summary>
	public float LowFreqAbsorption;
	///<summary>How much this material absorbs mid frequency sound.</summary>
	public float MidFreqAbsorption;
	///<summary>How much this material absorbs high frequency sound.</summary>
	public float HighFreqAbsorption;
	///<summary>How much this material transmits low frequency sound.</summary>
	public float LowFreqTransmission;
	///<summary>How much this material transmits mid frequency sound.</summary>
	public float MidFreqTransmission;
	///<summary>How much this material transmits high frequency sound.</summary>
	public float HighFreqTransmission;
	///<summary>Specifies how &quot;rough&quot; the surface is. Surfaces with a high scattering value randomly reflect sound in all directions;</summary>
	public float Scattering;
}

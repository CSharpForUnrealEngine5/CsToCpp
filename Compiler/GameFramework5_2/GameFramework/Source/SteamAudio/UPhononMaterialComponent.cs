#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononMaterialComponent.h")]
///<summary>Phonon Material components are used to customize an actor's acoustic properties. Only valid on actors that also</summary>
public partial class UPhononMaterialComponent : UActorComponent {
// PhononMaterialComponent
	public int MaterialIndex;
	public EPhononMaterial MaterialPreset;
	public float LowFreqAbsorption;
	public float MidFreqAbsorption;
	public float HighFreqAbsorption;
	public float LowFreqTransmission;
	public float MidFreqTransmission;
	public float HighFreqTransmission;
	public float Scattering;
}

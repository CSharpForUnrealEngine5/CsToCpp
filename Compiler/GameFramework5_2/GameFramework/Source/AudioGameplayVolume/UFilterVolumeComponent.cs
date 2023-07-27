#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FilterVolumeComponent.h")]
///<summary>UFilterVolumeComponent - Audio Gameplay Volume component for occlusion settings (volume filter)</summary>
public partial class UFilterVolumeComponent : UAudioGameplayVolumeMutator {
// FilterVolumeComponent
	public  void SetExteriorLPF(float Volume,float InterpolateTime) {}
	public  void SetInteriorLPF(float Volume,float InterpolateTime) {}
	public float ExteriorLPF;
	public float ExteriorLPFTime;
	public float InteriorLPF;
	public float InteriorLPFTime;
}

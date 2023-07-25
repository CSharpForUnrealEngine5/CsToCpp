#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeModulator.h")]
///<summary>Defines a random volume and pitch modification when a sound starts</summary>
public partial class USoundNodeModulator : USoundNode {
// SoundNodeModulator
	public float PitchMin;
	public float PitchMax;
	public float VolumeMin;
	public float VolumeMax;
}

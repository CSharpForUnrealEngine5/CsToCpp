#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSourceBus.h")]
///<summary>A source bus is a type of USoundBase and can be "played" like any sound.</summary>
public partial class USoundSourceBus : USoundWave {
// SoundSourceBus
	public ESourceBusChannels SourceBusChannels;
	public float SourceBusDuration;
	public UAudioBus AudioBus;
	public bool bAutoDeactivateWhenSilent;
}

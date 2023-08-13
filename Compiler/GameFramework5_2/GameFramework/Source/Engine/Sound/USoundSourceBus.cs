namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A source bus is a type of USoundBase and can be &quot;played&quot; like any sound.</summary>
[CppInclude("Sound/SoundSourceBus.h")]
public partial class USoundSourceBus : USoundWave {
	public static UClass StaticClass() {return default;}
	///<summary>How many channels to use for the source bus if the audio bus is not specified, otherwise it will use the audio bus object&#39;s channel count.</summary>
	public ESourceBusChannels SourceBusChannels;
	///<summary>The duration (in seconds) to use for the source bus. A duration of 0.0 indicates to play the source bus indefinitely.</summary>
	public float SourceBusDuration;
	///<summary>Audio bus to use as audio for this source bus. This source bus will sonify the audio from the audio bus.</summary>
	public UAudioBus AudioBus;
	///<summary>Stop the source bus when the volume goes to zero.</summary>
	public bool bAutoDeactivateWhenSilent;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundUtilities.h")]
///<summary>Sound Utilities Blueprint Function Library</summary>
public partial class USoundUtilitiesBPFunctionLibrary : UBlueprintFunctionLibrary {
// SoundUtilitiesBPFunctionLibrary
	public float GetBeatTempo(float BeatsPerMinute/*=120.0f*/,int BeatMultiplier/*=1*/,int DivisionsOfWholeNote/*=4*/) { return default; }
	public float GetFrequencyFromMIDIPitch(int MidiNote) { return default; }
	public int GetMIDIPitchFromFrequency(float Frequency) { return default; }
	public float GetPitchScaleFromMIDIPitch(int BaseMidiNote,int TargetMidiNote) { return default; }
	public float GetGainFromMidiVelocity(int InVelocity) { return default; }
	public float ConvertLinearToDecibels(float InLinear,float InFloor) { return default; }
	public float ConvertDecibelsToLinear(float InDecibels) { return default; }
	public float GetLogFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange) { return default; }
	public float GetLinearFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange) { return default; }
	public float GetFrequencyMultiplierFromSemitones(float InPitchSemitones) { return default; }
	public float GetBandwidthFromQ(float InQ) { return default; }
	public float GetQFromBandwidth(float InBandwidth) { return default; }
}

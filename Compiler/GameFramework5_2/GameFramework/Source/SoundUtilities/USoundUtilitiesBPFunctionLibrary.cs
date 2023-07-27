#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundUtilities.h")]
///<summary>Sound Utilities Blueprint Function Library</summary>
public partial class USoundUtilitiesBPFunctionLibrary : UBlueprintFunctionLibrary {
// SoundUtilitiesBPFunctionLibrary
	public static float GetBeatTempo(float BeatsPerMinute/*=120.0f*/,int BeatMultiplier/*=1*/,int DivisionsOfWholeNote/*=4*/) { return default; }
	public static float GetFrequencyFromMIDIPitch(int MidiNote) { return default; }
	public static int GetMIDIPitchFromFrequency(float Frequency) { return default; }
	public static float GetPitchScaleFromMIDIPitch(int BaseMidiNote,int TargetMidiNote) { return default; }
	public static float GetGainFromMidiVelocity(int InVelocity) { return default; }
	public static float ConvertLinearToDecibels(float InLinear,float InFloor) { return default; }
	public static float ConvertDecibelsToLinear(float InDecibels) { return default; }
	public static float GetLogFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange) { return default; }
	public static float GetLinearFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange) { return default; }
	public static float GetFrequencyMultiplierFromSemitones(float InPitchSemitones) { return default; }
	public static float GetBandwidthFromQ(float InQ) { return default; }
	public static float GetQFromBandwidth(float InBandwidth) { return default; }
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound Utilities Blueprint Function Library</summary>
[CppInclude("SoundUtilities.h")]
public partial class USoundUtilitiesBPFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>Calculates a beat time in seconds from the given BPM, beat multiplier and divisions of a whole note.</summary>
	public static float GetBeatTempo(float BeatsPerMinute/*=120.0f*/,int BeatMultiplier/*=1*/,int DivisionsOfWholeNote/*=4*/) { return default; }
	///<summary>Calculates Frequency values based on MIDI Pitch input</summary>
	public static float GetFrequencyFromMIDIPitch(int MidiNote) { return default; }
	///<summary>Calculates MIDI Pitch values based on frequency input</summary>
	public static int GetMIDIPitchFromFrequency(float Frequency) { return default; }
	///<summary>Calculates Pitch Scalar based on starting frequency and desired MIDI Pitch output</summary>
	public static float GetPitchScaleFromMIDIPitch(int BaseMidiNote,int TargetMidiNote) { return default; }
	///<summary>Given a velocity value [0,127], return the linear gain</summary>
	public static float GetGainFromMidiVelocity(int InVelocity) { return default; }
	///<summary>Converts linear scale volume to decibels</summary>
	public static float ConvertLinearToDecibels(float InLinear,float InFloor) { return default; }
	///<summary>Converts decibel to linear scale</summary>
	public static float ConvertDecibelsToLinear(float InDecibels) { return default; }
	///<summary>Returns the log frequency of the input value. Maps linear domain and range values to log output (good for linear slider controlling frequency)</summary>
	public static float GetLogFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange) { return default; }
	///<summary>Returns the linear frequency of the input value. Maps log domain and range values to linear output (good for linear</summary>
	public static float GetLinearFrequencyClamped(float InValue,FVector2D InDomain,FVector2D InRange) { return default; }
	///<summary>Returns the frequency multiplier to scale a base frequency given the input semitones</summary>
	public static float GetFrequencyMultiplierFromSemitones(float InPitchSemitones) { return default; }
	///<summary>Helper function to get bandwidth from Q</summary>
	public static float GetBandwidthFromQ(float InQ) { return default; }
	///<summary>Helper function to get Q from bandwidth</summary>
	public static float GetQFromBandwidth(float InBandwidth) { return default; }
}

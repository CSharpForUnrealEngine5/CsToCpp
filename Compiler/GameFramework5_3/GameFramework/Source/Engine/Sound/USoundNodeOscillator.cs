namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines how a sound oscillates</summary>
[CppInclude("Sound/SoundNodeOscillator.h")]
public partial class USoundNodeOscillator : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to oscillate volume.</summary>
	public bool bModulateVolume;
	///<summary>Whether to oscillate pitch.</summary>
	public bool bModulatePitch;
	///<summary>An amplitude of 0.25 would oscillate between 0.75 and 1.25.</summary>
	public float AmplitudeMin;
	///<summary>An amplitude of 0.25 would oscillate between 0.75 and 1.25.</summary>
	public float AmplitudeMax;
	///<summary>A frequency of 20 would oscillate at 10Hz.</summary>
	public float FrequencyMin;
	///<summary>A frequency of 20 would oscillate at 10Hz.</summary>
	public float FrequencyMax;
	///<summary>Offset into the sine wave. Value modded by 2 * PI.</summary>
	public float OffsetMin;
	///<summary>Offset into the sine wave. Value modded by 2 * PI.</summary>
	public float OffsetMax;
	///<summary>A center of 0.5 would oscillate around 0.5.</summary>
	public float CenterMin;
	///<summary>A center of 0.5 would oscillate around 0.5.</summary>
	public float CenterMax;
}

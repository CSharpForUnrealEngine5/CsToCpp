namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a random volume and pitch modification when a sound starts</summary>
[CppInclude("Sound/SoundNodeModulator.h")]
public partial class USoundNodeModulator : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>The lower bound of pitch (1.0 is no change).</summary>
	public float PitchMin;
	///<summary>The upper bound of pitch (1.0 is no change).</summary>
	public float PitchMax;
	///<summary>The lower bound of volume (1.0 is no change).</summary>
	public float VolumeMin;
	///<summary>The upper bound of volume (1.0 is no change).</summary>
	public float VolumeMax;
}

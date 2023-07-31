#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct defining a cue point in a sound wave asset</summary>
[CppInclude("Sound/SoundWave.h")]
public partial struct FSoundWaveCuePoint {
	public int CuePointID;
	public string Label;
	public int FramePosition;
	public int FrameLength;
}

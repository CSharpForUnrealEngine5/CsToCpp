#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound node that takes a runtime parameter for the wave to play</summary>
[CppInclude("Sound/SoundNodeWaveParam.h")]
public partial class USoundNodeWaveParam : USoundNode {
	///<summary>The name of the wave parameter to use to look up the SoundWave we should play</summary>
	public string WaveParameterName;
}

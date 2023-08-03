#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows named parameter based manipulation of pitch and volume</summary>
[CppInclude("Sound/SoundNodeModulatorContinuous.h")]
public partial class USoundNodeModulatorContinuous : USoundNode {
	public static UClass StaticClass() {return default;}
	///<summary>PitchModulationParams</summary>
	public FModulatorContinuousParams PitchModulationParams;
	///<summary>VolumeModulationParams</summary>
	public FModulatorContinuousParams VolumeModulationParams;
}

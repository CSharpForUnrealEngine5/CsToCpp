#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundModulationDestination.h")]
///<summary>Default parameter destination settings for source audio object.</summary>
public partial struct FSoundModulationDefaultSettings {
// SoundModulationDefaultSettings
	public FSoundModulationDestinationSettings VolumeModulationDestination;
	public FSoundModulationDestinationSettings PitchModulationDestination;
	public FSoundModulationDestinationSettings HighpassModulationDestination;
	public FSoundModulationDestinationSettings LowpassModulationDestination;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default parameter destination settings for source audio object.</summary>
[CppInclude("Sound/SoundModulationDestination.h")]
public partial struct FSoundModulationDefaultSettings {
	public FSoundModulationDestinationSettings VolumeModulationDestination;
	public FSoundModulationDestinationSettings PitchModulationDestination;
	public FSoundModulationDestinationSettings HighpassModulationDestination;
	public FSoundModulationDestinationSettings LowpassModulationDestination;
}

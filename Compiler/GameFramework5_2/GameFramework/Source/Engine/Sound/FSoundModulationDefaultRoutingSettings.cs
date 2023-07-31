#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Default parameter destination settings for source audio object.</summary>
[CppInclude("Sound/SoundModulationDestination.h")]
public partial struct FSoundModulationDefaultRoutingSettings {
	public EModulationRouting VolumeRouting;
	public EModulationRouting PitchRouting;
	public EModulationRouting HighpassRouting;
	public EModulationRouting LowpassRouting;
}

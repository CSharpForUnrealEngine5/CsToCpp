#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundModulationDestination.h")]
///<summary>Parameter destination settings allowing modulation control override for parameter destinations opting in to the Modulation System.</summary>
public partial struct FSoundModulationDestinationSettings {
// SoundModulationDestinationSettings
	public float Value;
	public bool bEnableModulation;
	public USoundModulatorBase Modulator;
	public TSet<USoundModulatorBase> Modulators;
}

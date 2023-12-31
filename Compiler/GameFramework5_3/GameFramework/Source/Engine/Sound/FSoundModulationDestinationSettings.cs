namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameter destination settings allowing modulation control override for parameter destinations opting in to the Modulation System.</summary>
[CppInclude("Sound/SoundModulationDestination.h")]
public partial struct FSoundModulationDestinationSettings {
	public float Value;
	public bool bEnableModulation;
	public USoundModulatorBase Modulator;
	public TSet<USoundModulatorBase> Modulators;
}

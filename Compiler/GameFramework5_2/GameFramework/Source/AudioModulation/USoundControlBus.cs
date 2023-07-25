#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundControlBus.h")]
public partial class USoundControlBus : USoundModulatorBase {
// SoundControlBus
	public bool bBypass;
	public bool bOverrideAddress;
	public string Address;
	public TArray<USoundModulationGenerator> Generators;
	public USoundModulationParameter Parameter;
}

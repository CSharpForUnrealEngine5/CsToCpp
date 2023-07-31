#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundModulationPatch.h")]
public partial struct FSoundControlModulationPatch {
	public bool bBypass;
	public USoundModulationParameter OutputParameter;
	public TArray<FSoundControlModulationInput> Inputs;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundModulationPatch.h")]
public partial struct FSoundControlModulationPatch {
	public bool bBypass;
	public USoundModulationParameter OutputParameter;
	public TArray<FSoundControlModulationInput> Inputs;
}

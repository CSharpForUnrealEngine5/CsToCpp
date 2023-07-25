#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EpicSynth1Types.h")]
public enum ESynthLFOPatchType {
	PatchToNone=0,
	PatchToGain=1,
	PatchToOscFreq=2,
	PatchToFilterFreq=3,
	PatchToFilterQ=4,
	PatchToOscPulseWidth=5,
	PatchToOscPan=6,
	PatchLFO1ToLFO2Frequency=7,
	PatchLFO1ToLFO2Gain=8,
	Count=9,
}

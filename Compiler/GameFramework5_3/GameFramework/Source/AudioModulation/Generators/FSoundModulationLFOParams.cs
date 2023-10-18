namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Generators/SoundModulationLFO.h")]
public partial struct FSoundModulationLFOParams {
	public ESoundModulationLFOShape Shape;
	public float ExponentialFactor;
	public float Width;
	public float Amplitude;
	public float Frequency;
	public float Offset;
	public float Phase;
	public bool bLooping;
	public bool bBypass;
}

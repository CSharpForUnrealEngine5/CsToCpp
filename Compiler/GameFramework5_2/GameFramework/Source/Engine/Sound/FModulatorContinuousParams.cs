namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeModulatorContinuous.h")]
public partial struct FModulatorContinuousParams {
	public string ParameterName;
	public float Default;
	public float MinInput;
	public float MaxInput;
	public float MinOutput;
	public float MaxOutput;
	public ModulationParamMode ParamMode;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AbcImportSettings.h")]
public partial struct FAbcSamplingSettings {
	public EAlembicSamplingType SamplingType;
	public int FrameSteps;
	public float TimeSteps;
	public int FrameStart;
	public int FrameEnd;
	public bool bSkipEmpty;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset used to store moto synth preset data.</summary>
[CppInclude("MotoSynthPreset.h")]
public partial class UMotoSynthPreset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Engine preview RPM curve</summary>
	public FRuntimeFloatCurve EnginePreviewRPMCurve;
	///<summary>Settings</summary>
	public FMotoSynthRuntimeSettings Settings;
	///<summary>StartEnginePreview</summary>
	public void StartEnginePreview() {}
	///<summary>StopEnginePreview</summary>
	public void StopEnginePreview() {}
	///<summary>Dumps memory usage of the preset (i.e. of the source assets)</summary>
	public void DumpRuntimeMemoryUsage() {}
}

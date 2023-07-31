#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to regulate Waveform Transformations behavior inside Waveform Editor plugin.</summary>
[CppInclude("WaveformEditorTransformationsSettings.h")]
public partial class UWaveformEditorTransformationsSettings : UDeveloperSettings {
	///<summary>A Transformation chain that will be added to the inspected Soundwave if there aren&#39;t any</summary>
	public TArray<UClass> LaunchTransformations;
}

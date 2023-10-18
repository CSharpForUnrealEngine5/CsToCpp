namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to regulate Waveform Transformations behavior inside Waveform Editor plugin.</summary>
[CppInclude("WaveformEditorTransformationsSettings.h")]
public partial class UWaveformEditorTransformationsSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>A Transformation chain that will be added to the inspected Soundwave if there aren&#39;t any</summary>
	public TArray<UClass> LaunchTransformations;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioAnalyzer</summary>
[CppInclude("AudioAnalyzer.h")]
public partial class UAudioAnalyzer : UObject {
	///<summary>The UAudioBus which is analyzed in real-time.</summary>
	public UAudioBus AudioBus;
	///<summary>Starts analyzing audio from the given audio bus. Optionally override the audio bus desired to analyze.</summary>
	public  void StartAnalyzing(UObject WorldContextObject,UAudioBus AudioBusToAnalyze) {}
	///<summary>Stops analyzing audio.</summary>
	public  void StopAnalyzing(UObject WorldContextObject/*=nullptr*/) {}
	///<summary>Audio analysis subsystem used with this audio analyzer</summary>
	public UAudioAnalyzerSubsystem AudioAnalyzerSubsystem;
}

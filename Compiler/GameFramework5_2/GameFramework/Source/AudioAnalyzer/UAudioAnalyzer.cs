#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioAnalyzer.h")]
///<summary>UAudioAnalyzer</summary>
public partial class UAudioAnalyzer : UObject {
// AudioAnalyzer
	public UAudioBus AudioBus;
	public void StartAnalyzing(UObject WorldContextObject,UObject AudioBusToAnalyze) {}
	public void StopAnalyzing(UObject WorldContextObject/*=nullptr*/) {}
	public UAudioAnalyzerSubsystem AudioAnalyzerSubsystem;
}

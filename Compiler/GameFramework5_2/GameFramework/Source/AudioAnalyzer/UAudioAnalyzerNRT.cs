#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAudioAnalyzerNRT</summary>
[CppInclude("AudioAnalyzerNRT.h")]
public partial class UAudioAnalyzerNRT : UAudioAnalyzerAssetBase {
	public static UClass StaticClass() {return default;}
	///<summary>The USoundWave which is analyzed.</summary>
	public USoundWave Sound;
	///<summary>The duration of the analyzed audio in seconds.</summary>
	public float DurationInSeconds;
	///<summary>Performs the analaysis of the audio</summary>
	public  void AnalyzeAudio() {}
}

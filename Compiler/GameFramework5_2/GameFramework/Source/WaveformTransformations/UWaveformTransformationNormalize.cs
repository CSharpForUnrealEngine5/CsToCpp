#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaveformTransformationNormalize.h")]
public partial class UWaveformTransformationNormalize : UWaveformTransformationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Target maximum volume for this soundwave, in decibels</summary>
	public float Target;
	///<summary>Will not apply more gain than this, even if the sound is very quiet</summary>
	public float MaxGain;
	///<summary>what type of analysis to run to find the peak value</summary>
	public ENormalizationMode Mode;
}

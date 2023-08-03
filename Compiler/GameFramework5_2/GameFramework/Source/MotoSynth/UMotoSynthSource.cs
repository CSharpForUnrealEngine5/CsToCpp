#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMotoSynthSource</summary>
[CppInclude("MotoSynthSourceAsset.h")]
public partial class UMotoSynthSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The source to use for the moto synth source</summary>
	public USoundWave SoundWaveSource;
	///<summary>Whether or not to convert this moto synth source to 8 bit on load to use less memory</summary>
	public bool bConvertTo8Bit;
	///<summary>Amount to scale down the sample rate of the source</summary>
	public float DownSampleFactor;
	///<summary>A curve to define the RPM contour from the min and max estimated RPM</summary>
	public FRuntimeFloatCurve RPMCurve;
	///<summary>Sets the volume of the RPM curve synth for testing RPM curve to source</summary>
	public float RPMSynthVolume;
	///<summary>Whether not to enable a low pass filter frequency before analyzing the audio file</summary>
	public bool bEnableFilteringForAnalysis;
	///<summary>Frequency of a low pass filter to apply before running grain table analysis</summary>
	public float LowPassFilterFrequency;
	///<summary>Whether not to enable a low pass filter frequency before analyzing the audio file</summary>
	public float HighPassFilterFrequency;
	///<summary>Whether not to enable a dynamics processor to the analysis step</summary>
	public bool bEnableDynamicsProcessorForAnalysis;
	///<summary>DynamicsProcessorLookahead</summary>
	public float DynamicsProcessorLookahead;
	///<summary>DynamicsProcessorInputGainDb</summary>
	public float DynamicsProcessorInputGainDb;
	///<summary>DynamicsProcessorRatio</summary>
	public float DynamicsProcessorRatio;
	///<summary>DynamicsKneeBandwidth</summary>
	public float DynamicsKneeBandwidth;
	///<summary>DynamicsProcessorThreshold</summary>
	public float DynamicsProcessorThreshold;
	///<summary>DynamicsProcessorAttackTimeMsec</summary>
	public float DynamicsProcessorAttackTimeMsec;
	///<summary>DynamicsProcessorReleaseTimeMsec</summary>
	public float DynamicsProcessorReleaseTimeMsec;
	///<summary>bEnableNormalizationForAnalysis</summary>
	public bool bEnableNormalizationForAnalysis;
	///<summary>SampleShiftOffset</summary>
	public int SampleShiftOffset;
	///<summary>A samples to use to calibrate when an engine cycle begins</summary>
	public int RPMCycleCalibrationSample;
	///<summary>The end of the first cycle sample. Cut the source file to start exactly on the cycle start</summary>
	public int RPMFirstCycleSampleEnd;
	///<summary>RPMEstimationOctaveOffset</summary>
	public int RPMEstimationOctaveOffset;
	///<summary>Whether not to write the audio used for analysis to a wav file</summary>
	public bool bWriteAnalysisInputToFile;
	///<summary>The path to write the audio analysis data (LPF and normalized asset)</summary>
	public string AnalysisInputFilePath;
	///<summary>PerformGrainTableAnalysis</summary>
	public  void PerformGrainTableAnalysis() {}
	///<summary>PlayToneMatch</summary>
	public  void PlayToneMatch() {}
	///<summary>StopToneMatch</summary>
	public  void StopToneMatch() {}
	///<summary>Data containing PCM audio of the imported source asset (filled out by the factory)</summary>
	public TArray<float> SourceData_DEPRECATED;
	///<summary>SourceDataPCM</summary>
	public TArray<short> SourceDataPCM;
	///<summary>Sample rate of the imported sound wave and the serialized data of the granulator</summary>
	public int SourceSampleRate;
	///<summary>Grain table containing information about how to granulate the source data buffer.</summary>
	public TArray<FGrainTableEntry> GrainTable;
}

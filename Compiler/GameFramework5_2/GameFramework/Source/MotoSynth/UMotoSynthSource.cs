#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotoSynthSourceAsset.h")]
///<summary>UMotoSynthSource</summary>
public partial class UMotoSynthSource : UObject {
// MotoSynthSource
	public USoundWave SoundWaveSource;
	public bool bConvertTo8Bit;
	public float DownSampleFactor;
	public FRuntimeFloatCurve RPMCurve;
	public float RPMSynthVolume;
	public bool bEnableFilteringForAnalysis;
	public float LowPassFilterFrequency;
	public float HighPassFilterFrequency;
	public bool bEnableDynamicsProcessorForAnalysis;
	public float DynamicsProcessorLookahead;
	public float DynamicsProcessorInputGainDb;
	public float DynamicsProcessorRatio;
	public float DynamicsKneeBandwidth;
	public float DynamicsProcessorThreshold;
	public float DynamicsProcessorAttackTimeMsec;
	public float DynamicsProcessorReleaseTimeMsec;
	public bool bEnableNormalizationForAnalysis;
	public int SampleShiftOffset;
	public int RPMCycleCalibrationSample;
	public int RPMFirstCycleSampleEnd;
	public int RPMEstimationOctaveOffset;
	public bool bWriteAnalysisInputToFile;
	public string AnalysisInputFilePath;
	public void PerformGrainTableAnalysis() {}
	public void PlayToneMatch() {}
	public void StopToneMatch() {}
	public TArray<float> SourceData_DEPRECATED;
	public TArray<short> SourceDataPCM;
	public int SourceSampleRate;
	public TArray<FGrainTableEntry> GrainTable;
}

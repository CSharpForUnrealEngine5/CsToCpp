#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public partial class UTimedDataMonitorSubsystem : UEngineSubsystem {
// TimedDataMonitorSubsystem
	public FTimedDataIdentifierListChangedSignature OnIdentifierListChanged_Dynamic;
	public  TArray<FTimedDataMonitorInputIdentifier> GetAllInputs() { return default; }
	public  TArray<FTimedDataMonitorChannelIdentifier> GetAllChannels() { return default; }
	public  TArray<FTimedDataMonitorChannelIdentifier> GetAllEnabledChannels() { return default; }
	public  void CalibrateLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo,FTimedDataMonitorCalibrationParameters CalibrationParameters,FTimedDataMonitorCalibrationResult Result) {}
	public  FTimedDataMonitorTimeCorrectionResult ApplyTimeCorrection(FTimedDataMonitorInputIdentifier Identifier,FTimedDataMonitorTimeCorrectionParameters TimeCorrectionParameters) { return default; }
	public  void ResetAllBufferStats() {}
	public  ETimedDataMonitorEvaluationState GetEvaluationState() { return default; }
	public  bool DoesInputExist(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  ETimedDataMonitorInputEnabled GetInputEnabled(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  void SetInputEnabled(FTimedDataMonitorInputIdentifier Identifier,bool bInEnabled) {}
	public  string GetInputDisplayName(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  TArray<FTimedDataMonitorChannelIdentifier> GetInputChannels(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  ETimedDataInputEvaluationType GetInputEvaluationType(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  void SetInputEvaluationType(FTimedDataMonitorInputIdentifier Identifier,ETimedDataInputEvaluationType Evaluation) {}
	public  float GetInputEvaluationOffsetInSeconds(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  void SetInputEvaluationOffsetInSeconds(FTimedDataMonitorInputIdentifier Identifier,float Seconds) {}
	public  float GetInputEvaluationOffsetInFrames(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  void SetInputEvaluationOffsetInFrames(FTimedDataMonitorInputIdentifier Identifier,float Frames) {}
	public  FFrameRate GetInputFrameRate(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  FTimedDataChannelSampleTime GetInputOldestDataTime(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  FTimedDataChannelSampleTime GetInputNewestDataTime(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  bool IsDataBufferSizeControlledByInput(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  int GetInputDataBufferSize(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  void SetInputDataBufferSize(FTimedDataMonitorInputIdentifier Identifier,int BufferSize) {}
	public  ETimedDataInputState GetInputConnectionState(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  ETimedDataMonitorEvaluationState GetInputEvaluationState(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  float GetInputEvaluationDistanceToNewestSampleMean(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  float GetInputEvaluationDistanceToOldestSampleMean(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  float GetInputEvaluationDistanceToNewestSampleStandardDeviation(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  float GetInputEvaluationDistanceToOldestSampleStandardDeviation(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	public  bool DoesChannelExist(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  bool IsChannelEnabled(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  void SetChannelEnabled(FTimedDataMonitorChannelIdentifier Identifier,bool bEnabled) {}
	public  FTimedDataMonitorInputIdentifier GetChannelInput(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  string GetChannelDisplayName(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  ETimedDataInputState GetChannelConnectionState(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  ETimedDataMonitorEvaluationState GetChannelEvaluationState(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  FTimedDataChannelSampleTime GetChannelOldestDataTime(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  FTimedDataChannelSampleTime GetChannelNewestDataTime(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  TArray<FTimedDataChannelSampleTime> GetChannelFrameDataTimes(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  int GetChannelNumberOfSamples(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  int GetChannelDataBufferSize(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  void SetChannelDataBufferSize(FTimedDataMonitorChannelIdentifier Identifier,int BufferSize) {}
	public  int GetChannelBufferUnderflowStat(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  int GetChannelBufferOverflowStat(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  int GetChannelFrameDroppedStat(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  void GetChannelLastEvaluationDataStat(FTimedDataMonitorChannelIdentifier Identifier,FTimedDataInputEvaluationData Result) {}
	public  float GetChannelEvaluationDistanceToNewestSampleMean(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  float GetChannelEvaluationDistanceToOldestSampleMean(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  float GetChannelEvaluationDistanceToNewestSampleStandardDeviation(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	public  float GetChannelEvaluationDistanceToOldestSampleStandardDeviation(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
}

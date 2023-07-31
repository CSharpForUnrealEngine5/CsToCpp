#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimedDataMonitorSubsystem.h")]
public partial class UTimedDataMonitorSubsystem : UEngineSubsystem {
	///<summary>Delegate of when an element is added or removed.</summary>
	public FTimedDataIdentifierListChangedSignature OnIdentifierListChanged_Dynamic;
	///<summary>Get the list of all the inputs.</summary>
	public  TArray<FTimedDataMonitorInputIdentifier> GetAllInputs() { return default; }
	///<summary>Get the list of all the channels.</summary>
	public  TArray<FTimedDataMonitorChannelIdentifier> GetAllChannels() { return default; }
	///<summary>Get the list of all the channels that are enabled.</summary>
	public  TArray<FTimedDataMonitorChannelIdentifier> GetAllEnabledChannels() { return default; }
	///<summary>Change the Timecode Provider offset to align all inputs and channels.</summary>
	public  void CalibrateLatent(UObject WorldContextObject,FLatentActionInfo LatentInfo,FTimedDataMonitorCalibrationParameters CalibrationParameters,FTimedDataMonitorCalibrationResult Result) {}
	///<summary>Assume all data samples were produce at the same time and align them with the current platform&#39;s time</summary>
	public  FTimedDataMonitorTimeCorrectionResult ApplyTimeCorrection(FTimedDataMonitorInputIdentifier Identifier,FTimedDataMonitorTimeCorrectionParameters TimeCorrectionParameters) { return default; }
	///<summary>Reset the stat of all the inputs.</summary>
	public  void ResetAllBufferStats() {}
	///<summary>Get the worst evaluation state of all the inputs.</summary>
	public  ETimedDataMonitorEvaluationState GetEvaluationState() { return default; }
	///<summary>Return true if the identifier is a valid input.</summary>
	public  bool DoesInputExist(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Is the input enabled in the monitor.</summary>
	public  ETimedDataMonitorInputEnabled GetInputEnabled(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Set all channels for the input enabled in the monitor.</summary>
	public  void SetInputEnabled(FTimedDataMonitorInputIdentifier Identifier,bool bInEnabled) {}
	///<summary>Return the display name of an input.</summary>
	public  string GetInputDisplayName(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Return the list of all channels that are part of the input.</summary>
	public  TArray<FTimedDataMonitorChannelIdentifier> GetInputChannels(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Get how the input is evaluated type.</summary>
	public  ETimedDataInputEvaluationType GetInputEvaluationType(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Set how the input is evaluated type.</summary>
	public  void SetInputEvaluationType(FTimedDataMonitorInputIdentifier Identifier,ETimedDataInputEvaluationType Evaluation) {}
	///<summary>Get the offset in seconds or frames (see GetEvaluationType) used at evaluation.</summary>
	public  float GetInputEvaluationOffsetInSeconds(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Set the offset in seconds or frames (see GetEvaluationType) used at evaluation.</summary>
	public  void SetInputEvaluationOffsetInSeconds(FTimedDataMonitorInputIdentifier Identifier,float Seconds) {}
	///<summary>Get the offset in frames (see GetEvaluationType) used at evaluation.</summary>
	public  float GetInputEvaluationOffsetInFrames(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Set the offset in frames (see GetEvaluationType) used at evaluation.</summary>
	public  void SetInputEvaluationOffsetInFrames(FTimedDataMonitorInputIdentifier Identifier,float Frames) {}
	///<summary>Get the frame rate at which the samples is produce.</summary>
	public  FFrameRate GetInputFrameRate(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Get the oldest sample time of all the channel in this input.</summary>
	public  FTimedDataChannelSampleTime GetInputOldestDataTime(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Get the latest sample time of all the channel in this input.</summary>
	public  FTimedDataChannelSampleTime GetInputNewestDataTime(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Does the channel support a different buffer size than it&#39;s input.</summary>
	public  bool IsDataBufferSizeControlledByInput(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Get the size of the buffer used by the input.</summary>
	public  int GetInputDataBufferSize(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Set the size of the buffer used by the input.</summary>
	public  void SetInputDataBufferSize(FTimedDataMonitorInputIdentifier Identifier,int BufferSize) {}
	///<summary>Get the worst state of all the channels of that input.</summary>
	public  ETimedDataInputState GetInputConnectionState(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Get the worst evaluation state of all the channels of that input.</summary>
	public  ETimedDataMonitorEvaluationState GetInputEvaluationState(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Returns the max average distance, in seconds, between evaluation time and newest sample</summary>
	public  float GetInputEvaluationDistanceToNewestSampleMean(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Returns the min average distance, in seconds, between evaluation time and oldest sample</summary>
	public  float GetInputEvaluationDistanceToOldestSampleMean(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Returns the standard deviation of the distance, in seconds, between evaluation time and newest sample</summary>
	public  float GetInputEvaluationDistanceToNewestSampleStandardDeviation(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Returns the standard deviation of the distance, in seconds, between evaluation time and oldest sample</summary>
	public  float GetInputEvaluationDistanceToOldestSampleStandardDeviation(FTimedDataMonitorInputIdentifier Identifier) { return default; }
	///<summary>Return true if the identifier is a valid channel.</summary>
	public  bool DoesChannelExist(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Is the channel enabled in the monitor.</summary>
	public  bool IsChannelEnabled(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Enable or disable an input from the monitor.</summary>
	public  void SetChannelEnabled(FTimedDataMonitorChannelIdentifier Identifier,bool bEnabled) {}
	///<summary>Return the input of this channel.</summary>
	public  FTimedDataMonitorInputIdentifier GetChannelInput(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Return the display name of an input.</summary>
	public  string GetChannelDisplayName(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Get the state the channel.</summary>
	public  ETimedDataInputState GetChannelConnectionState(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Get the evaluation state of the channel.</summary>
	public  ETimedDataMonitorEvaluationState GetChannelEvaluationState(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Get the channel oldest sample time.</summary>
	public  FTimedDataChannelSampleTime GetChannelOldestDataTime(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Get the channel latest sample time.</summary>
	public  FTimedDataChannelSampleTime GetChannelNewestDataTime(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Get the sample times for every frame in the channel</summary>
	public  TArray<FTimedDataChannelSampleTime> GetChannelFrameDataTimes(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Get the number of data samples available.</summary>
	public  int GetChannelNumberOfSamples(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>If the channel does support it, get the current maximum sample count of channel.</summary>
	public  int GetChannelDataBufferSize(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>If the channel does support it, set the maximum sample count of the channel.</summary>
	public  void SetChannelDataBufferSize(FTimedDataMonitorChannelIdentifier Identifier,int BufferSize) {}
	///<summary>Returns the number of buffer underflows detected by that input since the last reset.</summary>
	public  int GetChannelBufferUnderflowStat(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Returns the number of buffer overflows detected by that input since the last reset.</summary>
	public  int GetChannelBufferOverflowStat(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Returns the number of frames dropped by that input since the last reset.</summary>
	public  int GetChannelFrameDroppedStat(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Retrieves information about last evaluation</summary>
	public  void GetChannelLastEvaluationDataStat(FTimedDataMonitorChannelIdentifier Identifier,FTimedDataInputEvaluationData Result) {}
	///<summary>Returns the average distance, in seconds, between evaluation time and newest sample</summary>
	public  float GetChannelEvaluationDistanceToNewestSampleMean(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Returns the average distance, in seconds, between evaluation time and oldest sample</summary>
	public  float GetChannelEvaluationDistanceToOldestSampleMean(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Returns the standard deviation of the distance, in seconds, between evaluation time and newest sample</summary>
	public  float GetChannelEvaluationDistanceToNewestSampleStandardDeviation(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
	///<summary>Returns the standard deviation of the distance, in seconds, between evaluation time and oldest sample</summary>
	public  float GetChannelEvaluationDistanceToOldestSampleStandardDeviation(FTimedDataMonitorChannelIdentifier Identifier) { return default; }
}

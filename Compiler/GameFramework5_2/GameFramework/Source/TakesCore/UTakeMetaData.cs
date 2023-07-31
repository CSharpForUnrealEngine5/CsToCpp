#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Take meta-data that is stored on ULevelSequence assets that are recorded through the Take Recorder.</summary>
[CppInclude("TakeMetaData.h")]
public partial class UTakeMetaData : UObject {
	///<summary>Check whether this take is locked</summary>
	public  bool IsLocked() { return default; }
	///<summary>Check if this take was recorded (as opposed</summary>
	public  bool Recorded() { return default; }
	///<summary>@return The slate for this take</summary>
	public  string GetSlate() { return default; }
	///<summary>@return The take number for this take</summary>
	public  int GetTakeNumber() { return default; }
	///<summary>@return The timestamp for this take</summary>
	public  FDateTime GetTimestamp() { return default; }
	///<summary>@return The timecode in for this take</summary>
	public  FTimecode GetTimecodeIn() { return default; }
	///<summary>@return The timecode out for this take</summary>
	public  FTimecode GetTimecodeOut() { return default; }
	///<summary>@return The duration for this take</summary>
	public  FFrameTime GetDuration() { return default; }
	///<summary>@return The frame-rate for this take</summary>
	public  FFrameRate GetFrameRate() { return default; }
	///<summary>@return The user-provided description for this take</summary>
	public  string GetDescription() { return default; }
	///<summary>@return The preset on which the take was originally based</summary>
	public  UTakePreset GetPresetOrigin() { return default; }
	///<summary>@return The AssetPath of the Level used to create a Recorded Level Sequence</summary>
	public  string GetLevelPath() { return default; }
	///<summary>@return The Map used to create this recording</summary>
	public  ULevel GetLevelOrigin() { return default; }
	///<summary>@return Get if we get frame rate from time code</summary>
	public  bool GetFrameRateFromTimecode() { return default; }
	///<summary>Lock this take, causing it to become read-only</summary>
	public  void Lock() {}
	///<summary>Unlock this take if it is read-only, allowing it to be modified once again</summary>
	public  void Unlock() {}
	///<summary>Generate the desired asset path for this take meta-data</summary>
	public  string GenerateAssetPath(string PathFormatString) { return default; }
	///<summary>Set the slate for this take and reset its take number to 1</summary>
	public  void SetSlate(string InSlate,bool bEmitChanged/*=true*/) {}
	///<summary>Set this take&#39;s take number. Take numbers are always clamped to be &gt;= 1.</summary>
	public  void SetTakeNumber(int InTakeNumber,bool bEmitChanged/*=true*/) {}
	///<summary>Set this take&#39;s timestamp</summary>
	public  void SetTimestamp(FDateTime InTimestamp) {}
	///<summary>Set this take&#39;s timecode in</summary>
	public  void SetTimecodeIn(FTimecode InTimecodeIn) {}
	///<summary>Set this take&#39;s timecode out</summary>
	public  void SetTimecodeOut(FTimecode InTimecodeOut) {}
	///<summary>Set this take&#39;s duration</summary>
	public  void SetDuration(FFrameTime InDuration) {}
	///<summary>Set this take&#39;s frame-rate</summary>
	public  void SetFrameRate(FFrameRate InFrameRate) {}
	///<summary>Set this take&#39;s user-provided description</summary>
	public  void SetDescription(string InDescription) {}
	///<summary>Set the preset on which the take is based</summary>
	public  void SetPresetOrigin(UTakePreset InPresetOrigin) {}
	///<summary>Set the map used to create this recording</summary>
	public  void SetLevelOrigin(ULevel InLevelOrigin) {}
	///<summary>Set if we get frame rate from time code</summary>
	public  void SetFrameRateFromTimecode(bool InFromTimecode) {}
	///<summary>Whether the take is locked</summary>
	public bool bIsLocked;
	///<summary>The user-provided slate information for the take</summary>
	public string Slate;
	///<summary>The take number</summary>
	public int TakeNumber;
	///<summary>The timestamp at which the take was initiated</summary>
	public FDateTime Timestamp;
	///<summary>The timecode at the start of recording</summary>
	public FTimecode TimecodeIn;
	///<summary>The timecode at the end of recording</summary>
	public FTimecode TimecodeOut;
	///<summary>The desired duration for the take</summary>
	public FFrameTime Duration;
	///<summary>The frame rate the take was recorded at</summary>
	public FFrameRate FrameRate;
	///<summary>A user-provided description for the take</summary>
	public string Description;
	///<summary>The preset that the take was based off</summary>
	public TSoftObjectPtr<UTakePreset> PresetOrigin;
	///<summary>The level map used to create this recording</summary>
	public TSoftObjectPtr<ULevel> LevelOrigin;
	///<summary>Whether or not we get or frame rate from Timecode, default to true</summary>
	public bool bFrameRateFromTimecode;
}

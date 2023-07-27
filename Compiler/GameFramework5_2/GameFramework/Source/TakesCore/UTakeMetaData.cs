#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeMetaData.h")]
///<summary>Take meta-data that is stored on ULevelSequence assets that are recorded through the Take Recorder.</summary>
public partial class UTakeMetaData : UObject {
// TakeMetaData
	public  bool IsLocked() { return default; }
	public  bool Recorded() { return default; }
	public  string GetSlate() { return default; }
	public  int GetTakeNumber() { return default; }
	public  FDateTime GetTimestamp() { return default; }
	public  FTimecode GetTimecodeIn() { return default; }
	public  FTimecode GetTimecodeOut() { return default; }
	public  FFrameTime GetDuration() { return default; }
	public  FFrameRate GetFrameRate() { return default; }
	public  string GetDescription() { return default; }
	public  UTakePreset GetPresetOrigin() { return default; }
	public  string GetLevelPath() { return default; }
	public  ULevel GetLevelOrigin() { return default; }
	public  bool GetFrameRateFromTimecode() { return default; }
	public  void Lock() {}
	public  void Unlock() {}
	public  string GenerateAssetPath(string PathFormatString) { return default; }
	public  void SetSlate(string InSlate,bool bEmitChanged/*=true*/) {}
	public  void SetTakeNumber(int InTakeNumber,bool bEmitChanged/*=true*/) {}
	public  void SetTimestamp(FDateTime InTimestamp) {}
	public  void SetTimecodeIn(FTimecode InTimecodeIn) {}
	public  void SetTimecodeOut(FTimecode InTimecodeOut) {}
	public  void SetDuration(FFrameTime InDuration) {}
	public  void SetFrameRate(FFrameRate InFrameRate) {}
	public  void SetDescription(string InDescription) {}
	public  void SetPresetOrigin(UTakePreset InPresetOrigin) {}
	public  void SetLevelOrigin(ULevel InLevelOrigin) {}
	public  void SetFrameRateFromTimecode(bool InFromTimecode) {}
	public bool bIsLocked;
	public string Slate;
	public int TakeNumber;
	public FDateTime Timestamp;
	public FTimecode TimecodeIn;
	public FTimecode TimecodeOut;
	public FFrameTime Duration;
	public FFrameRate FrameRate;
	public string Description;
	public TSoftObjectPtr<UTakePreset> PresetOrigin;
	public TSoftObjectPtr<ULevel> LevelOrigin;
	public bool bFrameRateFromTimecode;
}

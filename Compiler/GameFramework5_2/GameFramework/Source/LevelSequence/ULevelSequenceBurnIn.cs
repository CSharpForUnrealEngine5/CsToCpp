#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceBurnIn.h")]
///<summary>Base class for level sequence burn ins</summary>
public partial class ULevelSequenceBurnIn : UUserWidget {
// LevelSequenceBurnIn
	public void SetSettings(UObject InSettings) {}
	public UClass GetSettingsClass() { return default; }
	public FLevelSequencePlayerSnapshot FrameInformation;
	public ALevelSequenceActor LevelSequenceActor;
}

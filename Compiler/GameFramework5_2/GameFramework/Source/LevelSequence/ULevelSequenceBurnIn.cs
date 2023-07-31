#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for level sequence burn ins</summary>
[CppInclude("LevelSequenceBurnIn.h")]
public partial class ULevelSequenceBurnIn : UUserWidget {
	///<summary>Called when this burn in is receiving its settings</summary>
	public  void SetSettings(UObject InSettings) {}
	///<summary>Get the settings class to use for this burn in</summary>
	public  UClass GetSettingsClass() { return default; }
	///<summary>Snapshot of frame information.</summary>
	public FLevelSequencePlayerSnapshot FrameInformation;
	///<summary>The actor to get our burn in frames from</summary>
	public ALevelSequenceActor LevelSequenceActor;
}

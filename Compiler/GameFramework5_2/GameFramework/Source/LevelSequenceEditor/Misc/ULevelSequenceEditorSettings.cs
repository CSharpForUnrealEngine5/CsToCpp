#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Misc/LevelSequenceEditorSettings.h")]
///<summary>Level Sequence Editor settings.</summary>
public partial class ULevelSequenceEditorSettings : UObject {
// LevelSequenceEditorSettings
	public TArray<FLevelSequenceTrackSettings> TrackSettings;
	public bool bAutoBindToPIE;
	public bool bAutoBindToSimulate;
}

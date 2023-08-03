#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Level Sequence Editor settings.</summary>
[CppInclude("Misc/LevelSequenceEditorSettings.h")]
public partial class ULevelSequenceEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies class properties for which movie scene tracks will be created automatically.</summary>
	public TArray<FLevelSequenceTrackSettings> TrackSettings;
	///<summary>Specifies whether to automatically bind an active sequencer UI to PIE worlds.</summary>
	public bool bAutoBindToPIE;
	///<summary>Specifies whether to automatically bind an active sequencer UI to simulate worlds.</summary>
	public bool bAutoBindToSimulate;
}

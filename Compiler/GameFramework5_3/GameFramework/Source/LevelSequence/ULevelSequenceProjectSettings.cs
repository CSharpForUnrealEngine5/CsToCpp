namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for level sequences</summary>
[CppInclude("LevelSequenceProjectSettings.h")]
public partial class ULevelSequenceProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>0: Playback locked to playback frames</summary>
	public bool bDefaultLockEngineToDisplayRate;
	///<summary>Specifies default display frame rate for newly created level sequences; also defines frame locked frame rate where sequences are set to be frame locked. Examples: 30 fps, 120/1 (120 fps), 30000/1001 (29.97), 0.01s (10ms).</summary>
	public string DefaultDisplayRate;
	///<summary>Specifies default tick resolution for newly created level sequences. Examples: 30 fps, 120/1 (120 fps), 30000/1001 (29.97), 0.01s (10ms).</summary>
	public string DefaultTickResolution;
	///<summary>Specifies default clock source for newly created level sequences. Examples: 0: Tick, 1: Platform, 2: Audio, 3: RelativeTimecode, 4: Timecode, 5: Custom</summary>
	public EUpdateClockSource DefaultClockSource;
}

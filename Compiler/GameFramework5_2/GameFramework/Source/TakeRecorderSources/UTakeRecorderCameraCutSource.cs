namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A recording source that detects camera switching and creates a camera cut track</summary>
[CppInclude("TakeRecorderCameraCutSource.h")]
public partial class UTakeRecorderCameraCutSource : UTakeRecorderSource {
	public static UClass StaticClass() {return default;}
	///<summary>World</summary>
	public UWorld World;
	///<summary>The root or uppermost level sequence that this source is being recorded into. Set during PreRecording, null after PostRecording.</summary>
	public ULevelSequence RootLevelSequence;
}

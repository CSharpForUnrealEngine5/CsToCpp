namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlayer.h")]
public partial class UMediaTimeStampInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Time</summary>
	public FTimespan Time;
	///<summary>SequenceIndex</summary>
	public long SequenceIndex;
}

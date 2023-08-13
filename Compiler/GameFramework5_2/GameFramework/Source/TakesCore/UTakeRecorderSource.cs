namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all sources that can be recorded with the Take Recorder. Custom recording sources can</summary>
[CppInclude("TakeRecorderSource.h")]
public partial class UTakeRecorderSource : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>True if this source is cued for recording or not</summary>
	public bool bEnabled;
	///<summary>TakeNumber</summary>
	public int TakeNumber;
	///<summary>TrackTint</summary>
	public FColor TrackTint;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderSource.h")]
///<summary>Base class for all sources that can be recorded with the Take Recorder. Custom recording sources can</summary>
public partial class UTakeRecorderSource : UObject {
// TakeRecorderSource
	public bool bEnabled;
	public int TakeNumber;
	public FColor TrackTint;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A capture protocol responsible for dealing with captured frames using some custom method (writing out to disk, streaming, etc)</summary>
[CppInclude("MovieSceneCaptureProtocolBase.h")]
public partial class UMovieSceneCaptureProtocolBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the current state of this capture protocol</summary>
	public  EMovieSceneCaptureProtocolState GetState() { return default; }
	///<summary>Check whether we can capture a frame from this protocol</summary>
	public  bool IsCapturing() { return default; }
	///<summary>The current state of the protocol</summary>
	public EMovieSceneCaptureProtocolState State;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneCaptureProtocolBase.h")]
///<summary>A capture protocol responsible for dealing with captured frames using some custom method (writing out to disk, streaming, etc)</summary>
public partial class UMovieSceneCaptureProtocolBase : UObject {
// MovieSceneCaptureProtocolBase
	public EMovieSceneCaptureProtocolState GetState() { return default; }
	public bool IsCapturing() { return default; }
	public EMovieSceneCaptureProtocolState State;
}

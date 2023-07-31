#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the GeometryCache streamer</summary>
[CppInclude("GeometryCacheStreamerSettings.h")]
public partial class UGeometryCacheStreamerSettings : UDeveloperSettings {
	///<summary>The amount of animation (in seconds) to stream ahead of time (per stream)</summary>
	public float LookAheadBuffer;
	///<summary>The maximum total amount of streamed data allowed in memory (for all streams)</summary>
	public float MaxMemoryAllowed;
}

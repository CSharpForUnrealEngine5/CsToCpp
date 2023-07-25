#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlayerOptions.h")]
public partial struct FMediaPlayerOptions {
// MediaPlayerOptions
	public FMediaPlayerTrackOptions Tracks;
	public FTimespan SeekTime;
	public EMediaPlayerOptionBooleanOverride PlayOnOpen;
	public EMediaPlayerOptionBooleanOverride Loop;
}

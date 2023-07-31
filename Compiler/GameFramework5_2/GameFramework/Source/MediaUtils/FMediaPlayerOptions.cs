#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlayerOptions.h")]
public partial struct FMediaPlayerOptions {
	public FMediaPlayerTrackOptions Tracks;
	public FTimespan SeekTime;
	public EMediaPlayerOptionBooleanOverride PlayOnOpen;
	public EMediaPlayerOptionBooleanOverride Loop;
}

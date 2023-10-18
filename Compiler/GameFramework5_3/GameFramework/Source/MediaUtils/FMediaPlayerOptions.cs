namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaPlayerOptions.h")]
public partial struct FMediaPlayerOptions {
	public FMediaPlayerTrackOptions Tracks;
	public FTimespan SeekTime;
	public EMediaPlayerOptionBooleanOverride PlayOnOpen;
	public EMediaPlayerOptionBooleanOverride Loop;
}

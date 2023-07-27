#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BinkMoviePlayerSettings.h")]
///<summary>Implements the settings for the Windows target platform.</summary>
public partial class UBinkMoviePlayerSettings : UObject {
// BinkMoviePlayerSettings
	public EBinkMoviePlayerBinkBufferModes BinkBufferMode;
	public EBinkMoviePlayerBinkSoundTrack BinkSoundTrack;
	public int BinkSoundTrackStart;
	public FVector2D BinkDestinationUpperLeft;
	public FVector2D BinkDestinationLowerRight;
	public EPixelFormat BinkPixelFormat;
}

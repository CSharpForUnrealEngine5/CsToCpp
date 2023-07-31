#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Windows target platform.</summary>
[CppInclude("BinkMoviePlayerSettings.h")]
public partial class UBinkMoviePlayerSettings : UObject {
	///<summary>Used to specify the how the video should be buffered.</summary>
	public EBinkMoviePlayerBinkBufferModes BinkBufferMode;
	///<summary>Used to specify the sounds to open at playback.</summary>
	public EBinkMoviePlayerBinkSoundTrack BinkSoundTrack;
	///<summary>Used to specify the sounds to open at playback.</summary>
	public int BinkSoundTrackStart;
	///<summary>Used to specify the render destination rectangle.</summary>
	public FVector2D BinkDestinationUpperLeft;
	///<summary>Used to specify the render destination rectangle.</summary>
	public FVector2D BinkDestinationLowerRight;
	///<summary>Used to specify the render destination rectangle.</summary>
	public EPixelFormat BinkPixelFormat;
}

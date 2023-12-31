namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the Windows target platform.</summary>
[CppInclude("BinkMoviePlayerSettings.h")]
public partial class UBinkMoviePlayerSettings : UObject {
	public static UClass StaticClass() {return default;}
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

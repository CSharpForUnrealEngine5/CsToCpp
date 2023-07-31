#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MediaPlayerRecording.h")]
public partial struct FMediaPlayerRecordingSettings {
	public bool bActive;
	public bool bRecordMediaFrame;
	public string BaseFilename;
	public EMediaPlayerRecordingNumerationStyle NumerationStyle;
	public EMediaPlayerRecordingImageFormat ImageFormat;
	public int CompressionQuality;
	public bool bResetAlpha;
}

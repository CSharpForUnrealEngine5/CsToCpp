#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/MediaPlayerEditorSettings.h")]
public partial class UMediaPlayerEditorSettings : UObject {
	///<summary>The name of the desired native media player to use for playback.</summary>
	public string DesiredPlayerName;
	///<summary>Whether to display overlay texts.</summary>
	public bool ShowTextOverlays;
	///<summary>How the video viewport should be scaled.</summary>
	public EMediaPlayerEditorScale ViewportScale;
}

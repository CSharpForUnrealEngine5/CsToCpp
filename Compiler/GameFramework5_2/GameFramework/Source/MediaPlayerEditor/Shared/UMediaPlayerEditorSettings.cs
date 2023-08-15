namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Shared/MediaPlayerEditorSettings.h")]
public partial class UMediaPlayerEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the desired native media player to use for playback.</summary>
	public FName DesiredPlayerName;
	///<summary>Whether to display overlay texts.</summary>
	public bool ShowTextOverlays;
	///<summary>How the video viewport should be scaled.</summary>
	public EMediaPlayerEditorScale ViewportScale;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Camera modifier that lets us set the correct FOV and post-process settings on the spectator pawn</summary>
[CppInclude("ReplayTracksEditorModule.h")]
public partial class UReplayTracksCameraModifier : UCameraModifier {
	public static UClass StaticClass() {return default;}
}

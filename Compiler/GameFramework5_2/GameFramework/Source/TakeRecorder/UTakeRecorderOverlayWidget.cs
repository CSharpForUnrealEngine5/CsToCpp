namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TakeRecorderOverlayWidget.h")]
public partial class UTakeRecorderOverlayWidget : UUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>The recorder that this overlay is reflecting</summary>
	public UTakeRecorder Recorder;
}

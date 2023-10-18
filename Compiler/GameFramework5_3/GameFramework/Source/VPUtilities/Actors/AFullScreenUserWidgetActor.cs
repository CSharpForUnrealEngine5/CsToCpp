namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Widgets are first rendered to a render target, then that render target is displayed in the world.</summary>
[CppInclude("Actors/VPFullScreenUserWidgetActor.h")]
public partial class AFullScreenUserWidgetActor : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>ScreenUserWidget</summary>
	public UVPFullScreenUserWidget ScreenUserWidget;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Widgets are first rendered to a render target, then that render target is displayed in the world.</summary>
[CppInclude("VPFullScreenUserWidgetActor.h")]
public partial class AFullScreenUserWidgetActor : AInfo {
	public static UClass StaticClass() {return default;}
	///<summary>ScreenUserWidget</summary>
	public UVPFullScreenUserWidget ScreenUserWidget;
}

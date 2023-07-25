#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPFullScreenUserWidget.h")]
///<summary>Will set the Widgets on a viewport either by Widgets are first rendered to a render target, then that render target is displayed in the world.</summary>
public partial class UVPFullScreenUserWidget : UObject {
// VPFullScreenUserWidget
	public EVPWidgetDisplayType EditorDisplayType;
	public EVPWidgetDisplayType GameDisplayType;
	public EVPWidgetDisplayType PIEDisplayType;
	public FVPFullScreenUserWidget_Viewport ViewportDisplayType;
	public UClass WidgetClass;
	public FVPFullScreenUserWidget_PostProcess PostProcessDisplayType;
	public UUserWidget Widget;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Will set the Widgets on a viewport either by Widgets are first rendered to a render target, then that render target is displayed in the world.</summary>
[CppInclude("VPFullScreenUserWidget.h")]
public partial class UVPFullScreenUserWidget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The display type when the world is an editor world.</summary>
	public EVPWidgetDisplayType EditorDisplayType;
	///<summary>The display type when the world is a game world.</summary>
	public EVPWidgetDisplayType GameDisplayType;
	///<summary>The display type when the world is a PIE world.</summary>
	public EVPWidgetDisplayType PIEDisplayType;
	///<summary>Behavior when the widget should be display by the slate attached to the viewport.</summary>
	public FVPFullScreenUserWidget_Viewport ViewportDisplayType;
	///<summary>The class of User Widget to create and display an instance of</summary>
	public UClass WidgetClass;
	///<summary>Behavior when the widget should be display by a post process.</summary>
	public FVPFullScreenUserWidget_PostProcess PostProcessDisplayType;
	///<summary>The User Widget object displayed and managed by this component</summary>
	public UUserWidget Widget;
}

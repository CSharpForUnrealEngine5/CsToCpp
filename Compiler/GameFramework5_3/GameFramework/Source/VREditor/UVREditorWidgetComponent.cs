namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A specialized WidgetComponent for the VREditor</summary>
[CppInclude("VREditorWidgetComponent.h")]
public partial class UVREditorWidgetComponent : UWidgetComponent {
	public static UClass StaticClass() {return default;}
	///<summary>High level redrawing policy for the widget component.</summary>
	public EVREditorWidgetDrawingPolicy DrawingPolicy;
	///<summary>Controls if we draw, the VREditorWidget allows for manual enabling or</summary>
	public bool bIsHovering;
	///<summary>Recorders if we&#39;ve drawn at least once, that way we can always draw the first</summary>
	public bool bHasEverDrawn;
}

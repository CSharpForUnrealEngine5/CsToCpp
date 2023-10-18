namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Will set the Widgets on a viewport either by Widgets are first rendered to a render target, then that render target is displayed in the world.</summary>
[CppInclude("Widgets/VPFullScreenUserWidget.h")]
public partial class UVPFullScreenUserWidget : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The class of User Widget to create and display an instance of</summary>
	public UClass WidgetClass;
	///<summary>The display type when the world is an editor world.</summary>
	public EVPWidgetDisplayType EditorDisplayType;
	///<summary>The display type when the world is a game world.</summary>
	public EVPWidgetDisplayType GameDisplayType;
	///<summary>The display type when the world is a PIE world.</summary>
	public EVPWidgetDisplayType PIEDisplayType;
	///<summary>Behavior when the widget should be display by the slate attached to the viewport.</summary>
	public FVPFullScreenUserWidget_Viewport ViewportDisplayType;
	///<summary>Behavior when the widget is rendered via a post process material via post process volume settings; the widget is added only over area rendered by anamorphic squeeze.</summary>
	public FVPFullScreenUserWidget_PostProcess PostProcessDisplayTypeWithBlendMaterial;
	///<summary>Behavior when the widget is rendered via a post process material via SceneViewExtensions; the widget is added over entire viewport, ignoring anamorphic squeeze.</summary>
	public FVPFullScreenUserWidget_PostProcessWithSVE PostProcessWithSceneViewExtensions;
	///<summary>The User Widget object displayed and managed by this component</summary>
	public UUserWidget Widget;
	///<summary>The world the widget is attached to.</summary>
	public TWeakObjectPtr<UWorld> World;
	///<summary>How we currently displaying the widget.</summary>
	public EVPWidgetDisplayType CurrentDisplayType;
}

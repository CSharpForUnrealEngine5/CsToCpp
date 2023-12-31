namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an interactive floating UI panel in the VR Editor</summary>
[CppInclude("UI/VREditorRadialFloatingUI.h")]
public partial class AVREditorRadialFloatingUI : AVREditorBaseActor {
	public static UClass StaticClass() {return default;}
	///<summary>When in a spawned state, this is the widget component to represent the widget</summary>
	public TArray<UVREditorWidgetComponent> WidgetComponents;
	///<summary>The floating window mesh</summary>
	public UStaticMeshComponent WindowMeshComponent;
	///<summary>The arrow indicator mesh</summary>
	public UStaticMeshComponent ArrowMeshComponent;
	///<summary>The central helper widget</summary>
	public UVREditorWidgetComponent CentralWidgetComponent;
}

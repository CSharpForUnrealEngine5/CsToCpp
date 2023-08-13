namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents an interactive floating UI panel in the VR Editor</summary>
[CppInclude("UI/VREditorFloatingUI.h")]
public partial class AVREditorFloatingUI : AVREditorBaseActor {
	public static UClass StaticClass() {return default;}
	///<summary>All params used to create this panel if this panel has a UMG widget and was created via BP. Invalid otherwise.</summary>
	public FVREditorFloatingUICreationContext CreationContext;
	///<summary>UMG user widget we&#39;re drawing, or nullptr if we&#39;re drawing a Slate widget</summary>
	public UUserWidget UserWidget;
	///<summary>When in a spawned state, this is the widget component to represent the widget</summary>
	public UVREditorWidgetComponent WidgetComponent;
	///<summary>The floating window mesh</summary>
	public UStaticMeshComponent WindowMeshComponent;
	///<summary>Class of the UMG widget we&#39;re spawning</summary>
	public UClass UserWidgetClass;
}

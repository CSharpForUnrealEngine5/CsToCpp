namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An interactive floating UI panel that can be dragged around</summary>
[CppInclude("UI/VREditorDockableWindow.h")]
public partial class AVREditorDockableWindow : AVREditorFloatingUI {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh underneath the window for docking it to the world</summary>
	public UStaticMeshComponent DockButtonMeshComponent;
	///<summary>Mesh underneath the window for easy selecting and dragging</summary>
	public UStaticMeshComponent SelectionBarMeshComponent;
	///<summary>Mesh that represents the close button for this UI</summary>
	public UStaticMeshComponent CloseButtonMeshComponent;
	///<summary>Dock Button dynamic material  (opaque)</summary>
	public UMaterialInstanceDynamic DockButtonMID;
	///<summary>Selection bar dynamic material  (opaque)</summary>
	public UMaterialInstanceDynamic SelectionBarMID;
	///<summary>Select bar dynamic material (translucent)</summary>
	public UMaterialInstanceDynamic SelectionBarTranslucentMID;
	///<summary>Close button dynamic material  (opaque)</summary>
	public UMaterialInstanceDynamic CloseButtonMID;
	///<summary>Close button dynamic material (translucent)</summary>
	public UMaterialInstanceDynamic CloseButtonTranslucentMID;
	///<summary>DragOperationComponent</summary>
	public UViewportDragOperationComponent DragOperationComponent;
}

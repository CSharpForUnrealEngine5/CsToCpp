#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/VREditorDockableWindow.h")]
///<summary>An interactive floating UI panel that can be dragged around</summary>
public partial class AVREditorDockableWindow : AVREditorFloatingUI {
// VREditorDockableWindow
	public UStaticMeshComponent DockButtonMeshComponent;
	public UStaticMeshComponent SelectionBarMeshComponent;
	public UStaticMeshComponent CloseButtonMeshComponent;
	public UMaterialInstanceDynamic DockButtonMID;
	public UMaterialInstanceDynamic SelectionBarMID;
	public UMaterialInstanceDynamic SelectionBarTranslucentMID;
	public UMaterialInstanceDynamic CloseButtonMID;
	public UMaterialInstanceDynamic CloseButtonTranslucentMID;
	public UViewportDragOperationComponent DragOperationComponent;
}

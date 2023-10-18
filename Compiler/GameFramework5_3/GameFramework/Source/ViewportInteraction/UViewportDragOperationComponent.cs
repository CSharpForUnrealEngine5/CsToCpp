namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container component for UViewportDragOperation that can be used by objects in the world that are draggable and implement the ViewportInteractableInterface</summary>
[CppInclude("ViewportDragOperation.h")]
public partial class UViewportDragOperationComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The actual dragging implementation</summary>
	public UViewportDragOperation DragOperation;
	///<summary>The next class that will be used as drag operation</summary>
	public UClass DragOperationSubclass;
}

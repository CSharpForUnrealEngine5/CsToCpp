#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Blueprint/DragDropOperation.h")]
///<summary>This class is the base drag drop operation for UMG, extend it to add additional data and add new functionality.</summary>
public partial class UDragDropOperation : UObject {
// DragDropOperation
	public string Tag;
	public UObject Payload;
	public UWidget DefaultDragVisual;
	public EDragPivot Pivot;
	public FVector2D Offset;
	public FOnDragDropMulticast OnDrop;
	public FOnDragDropMulticast OnDragCancelled;
	public FOnDragDropMulticast OnDragged;
	public  void Drop(FPointerEvent PointerEvent) {}
	public  void DragCancelled(FPointerEvent PointerEvent) {}
	public  void Dragged(FPointerEvent PointerEvent) {}
}

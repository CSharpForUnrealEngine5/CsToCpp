#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class is the base drag drop operation for UMG, extend it to add additional data and add new functionality.</summary>
[CppInclude("Blueprint/DragDropOperation.h")]
public partial class UDragDropOperation : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A simple string tag you can optionally use to provide extra metadata about the operation.</summary>
	public string Tag;
	///<summary>The payload of the drag operation.  This can be any UObject that you want to pass along as dragged data.  If you</summary>
	public UObject Payload;
	///<summary>The Drag Visual is the widget to display when dragging the item.  Normally people create a new widget to represent the</summary>
	public UWidget DefaultDragVisual;
	///<summary>Controls where the drag widget visual will appear when dragged relative to the pointer performing</summary>
	public EDragPivot Pivot;
	///<summary>A percentage offset (-1..+1) from the Pivot location, the percentage is of the desired size of the dragged visual.</summary>
	public FVector2D Offset;
	///<summary>OnDrop</summary>
	public FOnDragDropMulticast OnDrop;
	///<summary>OnDragCancelled</summary>
	public FOnDragDropMulticast OnDragCancelled;
	///<summary>OnDragged</summary>
	public FOnDragDropMulticast OnDragged;
	///<summary>Drop</summary>
	public  void Drop(FPointerEvent PointerEvent) {}
	///<summary>DragCancelled</summary>
	public  void DragCancelled(FPointerEvent PointerEvent) {}
	///<summary>Dragged</summary>
	public  void Dragged(FPointerEvent PointerEvent) {}
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/ControlRigContextMenuContext.h")]
public partial class UControlRigContextMenuContext : UObject {
	///<summary>Get the control rig blueprint that we are editing</summary>
	public  UControlRigBlueprint GetControlRigBlueprint() { return default; }
	///<summary>Get the active control rig instance in the viewport</summary>
	public  UControlRig GetControlRig() { return default; }
	///<summary>Returns true if either alt key is down</summary>
	public  bool IsAltDown() { return default; }
	///<summary>Returns context for a drag &amp; drop action that contains source and target element keys</summary>
	public  FControlRigRigHierarchyDragAndDropContext GetRigHierarchyDragAndDropContext() { return default; }
	///<summary>Returns context for graph node context menu</summary>
	public  FControlRigGraphNodeContextMenuContext GetGraphNodeContextMenuContext() { return default; }
	///<summary>Returns context for the menu that shows up when drag and drop from Rig Hierarchy to the Rig Graph</summary>
	public  FControlRigRigHierarchyToGraphDragAndDropContext GetRigHierarchyToGraphDragAndDropContext() { return default; }
}

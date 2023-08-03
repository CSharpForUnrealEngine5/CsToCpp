#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeITFComponent.h")]
public partial class UXRCreativeITFComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CanUndo</summary>
	public  bool CanUndo() { return default; }
	///<summary>CanRedo</summary>
	public  bool CanRedo() { return default; }
	///<summary>Undo</summary>
	public  void Undo() {}
	///<summary>Redo</summary>
	public  void Redo() {}
	///<summary>LeftMousePressed</summary>
	public  void LeftMousePressed() {}
	///<summary>LeftMouseReleased</summary>
	public  void LeftMouseReleased() {}
	///<summary>GetSelectionSet</summary>
	public  UTypedElementSelectionSet GetSelectionSet() { return default; }
	///<summary>HaveActiveTool</summary>
	public  bool HaveActiveTool() { return default; }
	///<summary>GetCurrentCoordinateSystem</summary>
	public  EToolContextCoordinateSystem GetCurrentCoordinateSystem() { return default; }
	///<summary>SetCurrentCoordinateSystem</summary>
	public  void SetCurrentCoordinateSystem(EToolContextCoordinateSystem CoordSystem) {}
	///<summary>FullTRSGizmoActorClass</summary>
	public UClass FullTRSGizmoActorClass;
	///<summary>PointerComponent</summary>
	public UXRCreativePointerComponent PointerComponent;
	///<summary>ToolsContext</summary>
	public UInteractiveToolsContext ToolsContext;
	///<summary>SelectionSet</summary>
	public UTypedElementSelectionSet SelectionSet;
	///<summary>SelectionInteraction</summary>
	public UXRCreativeSelectionInteraction SelectionInteraction;
	///<summary>TransformInteraction</summary>
	public UXRCreativeTransformInteraction TransformInteraction;
	///<summary>PDIRenderComponent</summary>
	public UXRCreativeITFRenderComponent PDIRenderComponent;
	///<summary>CurrentCoordinateSystem</summary>
	public EToolContextCoordinateSystem CurrentCoordinateSystem;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigGizmoActor.h")]
///<summary>An actor used to represent a rig control</summary>
public partial class AControlRigShapeActor : AActor {
// ControlRigShapeActor
	public USceneComponent ActorRootComponent;
	public UStaticMeshComponent StaticMeshComponent;
	public uint ControlRigIndex;
	public TWeakObjectPtr<UControlRig> ControlRig;
	public string ControlName;
	public string ShapeName;
	public string ColorParameterName;
	public void SetEnabled(bool bInEnabled) {}
	public bool IsEnabled() { return default; }
	public void SetSelected(bool bInSelected) {}
	public bool IsSelectedInEditor() { return default; }
	public void SetSelectable(bool bInSelectable) {}
	public void SetHovered(bool bInHovered) {}
	public bool IsHovered() { return default; }
	public void OnTransformChanged(FTransform NewTransform) {}
	public void OnEnabledChanged(bool bIsEnabled) {}
	public void OnSelectionChanged(bool bIsSelected) {}
	public void OnHoveredChanged(bool bIsSelected) {}
	public void OnManipulatingChanged(bool bIsManipulating) {}
	public void SetGlobalTransform(FTransform InTransform) {}
	public FTransform GetGlobalTransform() { return default; }
	public bool bSelected;
	public bool bHovered;
}

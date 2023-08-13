namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An actor used to represent a rig control</summary>
[CppInclude("ControlRigGizmoActor.h")]
public partial class AControlRigShapeActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>this is the one holding transform for the controls</summary>
	public USceneComponent ActorRootComponent;
	///<summary>this is visual representation of the transform</summary>
	public UStaticMeshComponent StaticMeshComponent;
	///<summary>the name of the control this actor is referencing</summary>
	public uint ControlRigIndex;
	///<summary>control rig this actor is referencing we can have multiple control rig&#39;s visible</summary>
	public TWeakObjectPtr<UControlRig> ControlRig;
	///<summary>the name of the control this actor is referencing</summary>
	public string ControlName;
	///<summary>the name of the shape to use on this actor</summary>
	public string ShapeName;
	///<summary>the name of the color parameter on the material</summary>
	public string ColorParameterName;
	///<summary>Set the control to be enabled/disabled</summary>
	public virtual void SetEnabled(bool bInEnabled) {}
	///<summary>Get whether the control is enabled/disabled</summary>
	public virtual bool IsEnabled() { return default; }
	///<summary>Set the control to be selected/unselected</summary>
	public virtual void SetSelected(bool bInSelected) {}
	///<summary>Get whether the control is selected/unselected</summary>
	public virtual bool IsSelectedInEditor() { return default; }
	///<summary>Set the control to be selected/unselected</summary>
	public virtual void SetSelectable(bool bInSelectable) {}
	///<summary>Set the control to be hovered</summary>
	public virtual void SetHovered(bool bInHovered) {}
	///<summary>Get whether the control is hovered</summary>
	public virtual bool IsHovered() { return default; }
	///<summary>Event called when the transform of this control has changed</summary>
	public void OnTransformChanged(FTransform NewTransform) {}
	///<summary>Event called when the enabled state of this control has changed</summary>
	public void OnEnabledChanged(bool bIsEnabled) {}
	///<summary>Event called when the selection state of this control has changed</summary>
	public void OnSelectionChanged(bool bIsSelected) {}
	///<summary>Event called when the hovered state of this control has changed</summary>
	public void OnHoveredChanged(bool bIsSelected) {}
	///<summary>Event called when the manipulating state of this control has changed</summary>
	public void OnManipulatingChanged(bool bIsManipulating) {}
	///<summary>this returns root component transform based on attach</summary>
	public void SetGlobalTransform(FTransform InTransform) {}
	///<summary>GetGlobalTransform</summary>
	public FTransform GetGlobalTransform() { return default; }
	///<summary>Whether this control is selected</summary>
	public bool bSelected;
	///<summary>Whether this control is hovered</summary>
	public bool bHovered;
}

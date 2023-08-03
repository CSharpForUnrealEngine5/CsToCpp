#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents the interactor in the world</summary>
[CppInclude("VRScoutingInteractor.h")]
public partial class UVRScoutingInteractor : UVREditorInteractor {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the gizmo mode for selected object</summary>
	public  void SetGizmoMode(EGizmoHandleTypes InGizmoMode) {}
	///<summary>Gets the gizmo mode for selected object</summary>
	public  EGizmoHandleTypes GetGizmoMode() { return default; }
	///<summary>Gets all actors that are selected in the world editor</summary>
	public static TArray<AActor> GetSelectedActors() { return default; }
	///<summary>Shown in Navigation mode</summary>
	public UStaticMeshComponent FlyingIndicatorComponent;
	///<summary>Returns the current InputComponent. This will be NULL unless bReceivesEditorInput is set to true.</summary>
	public  UInputComponent GetInputComponent() { return default; }
	///<summary>SetReceivesEditorInput</summary>
	public  void SetReceivesEditorInput(bool bInValue) {}
	///<summary>GetReceivesEditorInput</summary>
	public  bool GetReceivesEditorInput() { return default; }
	///<summary>EditorOnlyInputComponent</summary>
	public UInputComponent EditorOnlyInputComponent;
	///<summary>If set to true, then this interactor will be able to recieve input delegate callbacks when in the editor. Defaults to true since we will always want this interactor to consume input</summary>
	public bool bReceivesEditorInput;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VRScoutingInteractor.h")]
///<summary>Represents the interactor in the world</summary>
public partial class UVRScoutingInteractor : UVREditorInteractor {
// VRScoutingInteractor
	public  void SetGizmoMode(EGizmoHandleTypes InGizmoMode) {}
	public  EGizmoHandleTypes GetGizmoMode() { return default; }
	public static TArray<AActor> GetSelectedActors() { return default; }
	public UStaticMeshComponent FlyingIndicatorComponent;
	public  UInputComponent GetInputComponent() { return default; }
	public  void SetReceivesEditorInput(bool bInValue) {}
	public  bool GetReceivesEditorInput() { return default; }
	public UInputComponent EditorOnlyInputComponent;
	public bool bReceivesEditorInput;
}

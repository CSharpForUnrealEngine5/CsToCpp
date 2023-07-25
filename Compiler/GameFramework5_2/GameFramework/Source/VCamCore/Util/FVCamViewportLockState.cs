#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Util/VCamViewportLocker.h")]
public partial struct FVCamViewportLockState {
// VCamViewportLockState
	public bool bLockViewportToCamera;
	public bool bWasLockedToViewport;
	public bool bIsForceLocked;
	public TWeakObjectPtr<AActor> LastKnownEditorLockActor;
	public TWeakObjectPtr<AActor> Backup_ViewTarget;
}

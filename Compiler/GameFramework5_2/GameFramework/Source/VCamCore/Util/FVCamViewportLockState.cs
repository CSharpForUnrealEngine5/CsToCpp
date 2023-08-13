namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Util/VCamViewportLocker.h")]
public partial struct FVCamViewportLockState {
	public bool bLockViewportToCamera;
	public bool bWasLockedToViewport;
	public bool bIsForceLocked;
	public TWeakObjectPtr<AActor> LastKnownEditorLockActor;
	public TWeakObjectPtr<AActor> Backup_ViewTarget;
}

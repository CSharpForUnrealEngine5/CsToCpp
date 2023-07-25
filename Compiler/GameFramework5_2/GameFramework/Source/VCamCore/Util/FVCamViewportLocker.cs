#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Util/VCamViewportLocker.h")]
///<summary>Keeps track of which viewports are locked</summary>
public partial struct FVCamViewportLocker {
// VCamViewportLocker
	public TMap<EVCamTargetViewportID,FVCamViewportLockState> Locks;
}

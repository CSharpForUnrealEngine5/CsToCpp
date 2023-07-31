#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Keeps track of which viewports are locked</summary>
[CppInclude("Util/VCamViewportLocker.h")]
public partial struct FVCamViewportLocker {
	public TMap<EVCamTargetViewportID,FVCamViewportLockState> Locks;
}

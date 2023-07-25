#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/ControlRigSequence.h")]
public partial class UControlRigSequence : ULevelSequence {
// ControlRigSequence
	public TSoftObjectPtr<UAnimSequence> LastExportedToAnimationSequence;
	public TSoftObjectPtr<USkeletalMesh> LastExportedUsingSkeletalMesh;
	public float LastExportedFrameRate;
}

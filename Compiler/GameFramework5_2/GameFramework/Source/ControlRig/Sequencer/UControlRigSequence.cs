namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/ControlRigSequence.h")]
public partial class UControlRigSequence : ULevelSequence {
	public static UClass StaticClass() {return default;}
	///<summary>The last animation sequence this control rig sequence was exported to</summary>
	public TSoftObjectPtr<UAnimSequence> LastExportedToAnimationSequence;
	///<summary>The skeletal mesh that was used the last time we exported this sequence</summary>
	public TSoftObjectPtr<USkeletalMesh> LastExportedUsingSkeletalMesh;
	///<summary>The frame rate that was used the last time we exported this sequence</summary>
	public float LastExportedFrameRate;
}

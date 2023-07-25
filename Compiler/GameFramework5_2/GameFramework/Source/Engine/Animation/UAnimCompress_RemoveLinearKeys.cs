#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompress_RemoveLinearKeys.h")]
public partial class UAnimCompress_RemoveLinearKeys : UAnimCompress {
// AnimCompress_RemoveLinearKeys
	public float MaxPosDiff;
	public float MaxAngleDiff;
	public float MaxScaleDiff;
	public float MaxEffectorDiff;
	public float MinEffectorDiff;
	public float EffectorDiffSocket;
	public float ParentKeyScale;
	public bool bRetarget;
	public bool bActuallyFilterLinearKeys;
}

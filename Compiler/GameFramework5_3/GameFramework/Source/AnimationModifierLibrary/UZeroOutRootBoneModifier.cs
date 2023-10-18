namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adjust root motion to be relative to the first frame. Optionally cut the start and end sections of the animation that don&#39;t have motion on the root.</summary>
[CppInclude("ZeroOutRootBoneModifier.h")]
public partial class UZeroOutRootBoneModifier : UAnimationModifier {
	public static UClass StaticClass() {return default;}
	///<summary>Clip frames at the start of the animation that have no root motion.</summary>
	public bool bClipStartFramesWithNoMotion;
	///<summary>Clip frames at the end of the animation that have no root motion.</summary>
	public bool bClipEndFramesWithNoMotion;
}

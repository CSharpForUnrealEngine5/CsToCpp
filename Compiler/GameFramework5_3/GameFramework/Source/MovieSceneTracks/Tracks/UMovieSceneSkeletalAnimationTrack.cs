namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles animation of skeletal mesh actors</summary>
[CppInclude("Tracks/MovieSceneSkeletalAnimationTrack.h")]
public partial class UMovieSceneSkeletalAnimationTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of all animation sections</summary>
	public TArray<UMovieSceneSection> AnimationSections;
	///<summary>bUseLegacySectionIndexBlend</summary>
	public bool bUseLegacySectionIndexBlend;
	///<summary>RootMotionParams</summary>
	public FMovieSceneSkeletalAnimRootMotionTrackParams RootMotionParams;
	///<summary>Whether to blend and adjust the first child node with animation instead of the root, this should be true for blending when the root is static, false if the animations have proper root motion</summary>
	public bool bBlendFirstChildOfRoot;
	///<summary>If on the root bone transform will be swapped to the specified root</summary>
	public ESwapRootBone SwapRootBone;
	///<summary>SetSwapRootBone</summary>
	public void SetSwapRootBone(ESwapRootBone InValue) {}
	///<summary>GetSwapRootBone</summary>
	public ESwapRootBone GetSwapRootBone() { return default; }
	///<summary>Whether to show the position of the root for this sections</summary>
	public bool bShowRootMotionTrail;
}

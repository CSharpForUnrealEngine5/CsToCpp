namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An Anim Blueprint is essentially a specialized Blueprint whose graphs control the animation of a Skeletal Mesh.</summary>
[CppInclude("Animation/AnimBlueprint.h")]
public partial class UAnimBlueprint : UBlueprint {
	public static UClass StaticClass() {return default;}
	///<summary>This is the target skeleton asset for anim instances created from this blueprint; all animations</summary>
	public USkeleton TargetSkeleton;
	///<summary>List of animation sync groups</summary>
	public TArray<FAnimGroupInfo> Groups;
	///<summary>This is an anim blueprint that acts as a set of template functionality without being tied to a specific skeleton.</summary>
	public bool bIsTemplate;
	///<summary>Allows this anim Blueprint to update its native update, blend tree, montages and asset players on</summary>
	public bool bUseMultiThreadedAnimationUpdate;
	///<summary>Selecting this option will cause the compiler to emit warnings whenever a call into Blueprint</summary>
	public bool bWarnAboutBlueprintUsage;
	///<summary>If true, linked animation layers will be instantiated only once per AnimClass instead of once per AnimInstance, AnimClass and AnimGroup.</summary>
	public bool bEnableLinkedAnimLayerInstanceSharing;
	///<summary>Array of overrides to asset containing nodes in the parent that have been overridden</summary>
	public TArray<FAnimParentNodeAssetOverride> ParentAssetOverrides;
	///<summary>Array of active pose watches (pose watches allows us to see the bone pose at a</summary>
	public TArray<UPoseWatchFolder> PoseWatchFolders;
	///<summary>PoseWatches</summary>
	public TArray<UPoseWatch> PoseWatches;
	///<summary>The default skeletal mesh to use when previewing this asset - this only applies when you open Persona using this asset</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	///<summary>An animation Blueprint to overlay with this Blueprint. When working on layers, this allows this Blueprint to be previewed in the context of another &#39;outer&#39; anim blueprint.</summary>
	public TSoftObjectPtr<UAnimBlueprint> PreviewAnimationBlueprint;
	///<summary>The method by which a preview animation blueprint is applied, either as an overlay layer, or as a linked instance</summary>
	public EPreviewAnimationBlueprintApplicationMethod PreviewAnimationBlueprintApplicationMethod;
	///<summary>The tag to use when applying a preview animation blueprint via LinkAnimGraphByTag</summary>
	public string PreviewAnimationBlueprintTag;
}

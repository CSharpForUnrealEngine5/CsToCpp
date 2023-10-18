namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeGenericAssetsPipelineSharedSettings.h")]
public partial class UInterchangeGenericCommonSkeletalMeshesAndAnimationsProperties : UInterchangePipelineBase {
	public static UClass StaticClass() {return default;}
	///<summary>Enable this option to only import animation, a valid skeleton must be set to import only the animations.</summary>
	public bool bImportOnlyAnimations;
	///<summary>Skeleton to use for imported asset. When importing a skeletal mesh, leaving this as &quot;None&quot; will create a new skeleton. When importing an animation this MUST be specified to import the asset.</summary>
	public TWeakObjectPtr<USkeleton> Skeleton;
	///<summary>If checked, meshes nested in bone hierarchies will be imported instead of being converted to bones.</summary>
	public bool bImportMeshesInBoneHierarchy;
	///<summary>Enable this option to use frame 0 as reference pose</summary>
	public bool bUseT0AsRefPose;
	///<summary>Allow to convert static mesh using morph target to skeletal mesh&quot;</summary>
	public bool bConvertStaticsWithMorphTargetsToSkeletals;
}

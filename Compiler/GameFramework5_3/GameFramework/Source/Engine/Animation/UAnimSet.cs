namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSet.h")]
public partial class UAnimSet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Indicates that only the rotation should be taken from the animation sequence and the translation should come from the USkeletalMesh ref pose.</summary>
	public bool bAnimRotationOnly;
	///<summary>Bone name that each track relates to. TrackBoneName.Num() == Number of tracks.</summary>
	public TArray<FName> TrackBoneNames;
	///<summary>Actual animation sequence information.</summary>
	public TArray<UAnimSequence> Sequences;
	///<summary>Non-serialised cache of linkups between different skeletal meshes and this AnimSet. // Do not change private - they will go away</summary>
	public TArray<FAnimSetMeshLinkup> LinkupCache;
	///<summary>Array of booleans that indicate whether or not to read the translation of a bone from animation or ref skeleton.</summary>
	public TArray<byte> BoneUseAnimTranslation;
	///<summary>Cooked down version of ForceMeshTranslationBoneNames // Do not change private - they will go away</summary>
	public TArray<byte> ForceUseMeshTranslation;
	///<summary>Names of bones that should use translation from the animation, if bAnimRotationOnly is set. // Do not change private - they will go away</summary>
	public TArray<FName> UseTranslationBoneNames;
	///<summary>List of bones which are ALWAYS going to use their translation from the mesh and not the animation. // Do not change private - they will go away</summary>
	public TArray<FName> ForceMeshTranslationBoneNames;
	///<summary>In the AnimSetEditor, when you switch to this AnimSet, it sees if this skeletal mesh is loaded and if so switches to it.</summary>
	public FName PreviewSkelMeshName;
	///<summary>Holds the name of the skeletal mesh whose reference skeleton best matches the TrackBoneName array.</summary>
	public FName BestRatioSkelMeshName;
}

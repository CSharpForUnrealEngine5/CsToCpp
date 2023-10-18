namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimToTextureDataAsset.h")]
public partial class UAnimToTextureDataAsset : UPrimaryDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletalMesh to bake animations from.</summary>
	public TSoftObjectPtr<USkeletalMesh> SkeletalMesh;
	///<summary>SkeletalMesh LOD to bake.</summary>
	public int SkeletalLODIndex;
	///<summary>StaticMesh to bake to.</summary>
	public TSoftObjectPtr<UStaticMesh> StaticMesh;
	///<summary>StaticMesh LOD to bake to.</summary>
	public int StaticLODIndex;
	///<summary>StaticMesh UVChannel Index for storing vertex information.</summary>
	public int UVChannel;
	///<summary>Number of Driver Triangles</summary>
	public int NumDriverTriangles;
	///<summary>Inverse Distance Weighting</summary>
	public float Sigma;
	///<summary>Max resolution of the texture.</summary>
	public int MaxHeight;
	///<summary>Max resolution of the texture.</summary>
	public int MaxWidth;
	///<summary>Enforce Power Of Two on texture resolutions.</summary>
	public bool bEnforcePowerOfTwo;
	///<summary>Texture Precision</summary>
	public EAnimToTexturePrecision Precision;
	///<summary>Storage Mode.</summary>
	public EAnimToTextureMode Mode;
	///<summary>Texture for storing vertex positions</summary>
	public TSoftObjectPtr<UTexture2D> VertexPositionTexture;
	///<summary>Texture for storing vertex normals</summary>
	public TSoftObjectPtr<UTexture2D> VertexNormalTexture;
	///<summary>Texture for storing bone positions</summary>
	public TSoftObjectPtr<UTexture2D> BonePositionTexture;
	///<summary>Texture for storing bone rotations</summary>
	public TSoftObjectPtr<UTexture2D> BoneRotationTexture;
	///<summary>Texture for storing vertex/bone weighting</summary>
	public TSoftObjectPtr<UTexture2D> BoneWeightTexture;
	///<summary>Adds transformation to baked textures.</summary>
	public FTransform RootTransform;
	///<summary>Bone used for Rigid Binding. The bone needs to be part of the RawBones.</summary>
	public FName AttachToSocket;
	///<summary>SampleRate</summary>
	public float SampleRate;
	///<summary>AnimSequences</summary>
	public TArray<FAnimToTextureAnimSequenceInfo> AnimSequences;
	///<summary>AutoPlay will use Engine Time for driving the animation.</summary>
	public bool bAutoPlay;
	///<summary>AnimationIndex Index of the animation to play.</summary>
	public int AnimationIndex;
	///<summary>Frame to play</summary>
	public int Frame;
	///<summary>Number of Bone Influences for deformation. More influences will produce smoother results at the cost of performance.</summary>
	public EAnimToTextureNumBoneInfluences NumBoneInfluences;
	///<summary>Total Number of Frames in all animations</summary>
	public int NumFrames;
	///<summary>Total Number of Bones</summary>
	public int NumBones;
	///<summary>VertexRowsPerFrame</summary>
	public int VertexRowsPerFrame;
	///<summary>VertexMinBBox</summary>
	public FVector3f VertexMinBBox;
	///<summary>VertexSizeBBox</summary>
	public FVector3f VertexSizeBBox;
	///<summary>BoneWeightRowsPerFrame</summary>
	public int BoneWeightRowsPerFrame;
	///<summary>BoneRowsPerFrame</summary>
	public int BoneRowsPerFrame;
	///<summary>BoneMinBBox</summary>
	public FVector3f BoneMinBBox;
	///<summary>BoneSizeBBox</summary>
	public FVector3f BoneSizeBBox;
	///<summary>Animations</summary>
	public TArray<FAnimToTextureAnimInfo> Animations;
	///<summary>Finds AnimSequence Index in the Animations Array.</summary>
	public int GetIndexFromAnimSequence(UAnimSequence Sequence) { return default; }
	///<summary>ResetInfo</summary>
	public void ResetInfo() {}
	///<summary>BP_GetStaticMesh</summary>
	public UStaticMesh BP_GetStaticMesh() { return default; }
	///<summary>BP_GetSkeletalMesh</summary>
	public USkeletalMesh BP_GetSkeletalMesh() { return default; }
	///<summary>BP_GetBonePositionTexture</summary>
	public UTexture2D BP_GetBonePositionTexture() { return default; }
	///<summary>BP_GetBoneRotationTexture</summary>
	public UTexture2D BP_GetBoneRotationTexture() { return default; }
	///<summary>BP_GetBoneWeightTexture</summary>
	public UTexture2D BP_GetBoneWeightTexture() { return default; }
}

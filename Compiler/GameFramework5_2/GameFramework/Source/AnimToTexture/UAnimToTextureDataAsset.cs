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
	///<summary>Bone used for Rigid Binding. The bone needs to be part of the RawBones.</summary>
	public FName AttachToSocket;
	///<summary>SampleRate</summary>
	public float SampleRate;
	///<summary>AnimSequences</summary>
	public TArray<FAnimSequenceInfo> AnimSequences;
	///<summary>Total Number of Frames in all animations</summary>
	public int NumFrames;
	///<summary>VertexRowsPerFrame</summary>
	public int VertexRowsPerFrame;
	///<summary>VertexMinBBox</summary>
	public FVector VertexMinBBox;
	///<summary>VertexSizeBBox</summary>
	public FVector VertexSizeBBox;
	///<summary>BoneWeightRowsPerFrame</summary>
	public int BoneWeightRowsPerFrame;
	///<summary>BoneRowsPerFrame</summary>
	public int BoneRowsPerFrame;
	///<summary>BoneMinBBox</summary>
	public FVector BoneMinBBox;
	///<summary>BoneSizeBBox</summary>
	public FVector BoneSizeBBox;
	///<summary>Animations</summary>
	public TArray<FAnimInfo> Animations;
	///<summary>GetIndexFromAnimSequence</summary>
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

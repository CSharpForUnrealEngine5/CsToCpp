#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerMorphModel.h")]
public partial class UMLDeformerMorphModel : UMLDeformerGeomCacheModel {
// MLDeformerMorphModel
	public  void SetMorphTargetDeltaFloats(TArray<float> Deltas) {}
	public  void SetMorphTargetDeltas(TArray<FVector3f> Deltas) {}
	public  void SetMorphTargetsErrorOrder(TArray<int> MorphTargetOrder,TArray<float> ErrorValues) {}
	public  void SetMorphTargetsMaxWeights(TArray<float> MaxWeights) {}
	public TArray<FVector3f> MorphTargetDeltas;
	public int NumMorphTargets;
	public ulong CompressedMorphDataSizeInBytes;
	public ulong UncompressedMorphDataSizeInBytes;
	public TArray<int> MorphTargetErrorOrder;
	public TArray<float> MorphTargetErrors;
	public TArray<float> MaxMorphWeights;
	public TArray<FMLDeformerMorphModelQualityLevel> QualityLevels;
	public bool bIncludeNormals;
	public float MorphDeltaZeroThreshold;
	public float MorphCompressionLevel;
	public EMLDeformerMaskChannel MaskChannel;
	public bool bInvertMaskChannel;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerMorphModel.h")]
public partial class UMLDeformerMorphModel : UMLDeformerGeomCacheModel {
	public static UClass StaticClass() {return default;}
	///<summary>Set the per vertex deltas, as a set of floats. Each vertex delta must have 3 floats.</summary>
	public  void SetMorphTargetDeltaFloats(TArray<float> Deltas) {}
	///<summary>Set the morph target model deltas as an array of 3D vectors.</summary>
	public  void SetMorphTargetDeltas(TArray<FVector3f> Deltas) {}
	///<summary>Set the order of importance during LOD, for the morph targets.</summary>
	public  void SetMorphTargetsErrorOrder(TArray<int> MorphTargetOrder,TArray<float> ErrorValues) {}
	///<summary>Set the maximum weights for each morph target when we pass the training inputs into the trained neural network.</summary>
	public  void SetMorphTargetsMaxWeights(TArray<float> MaxWeights) {}
	///<summary>The entire set of uncompressed morph target deltas, 3 per vertex, for each morph target, as one flattened buffer.</summary>
	public TArray<FVector3f> MorphTargetDeltas;
	///<summary>The number of morph targets.</summary>
	public int NumMorphTargets;
	///<summary>The compressed memory usage of the morph targets. This is approximately what this MLD asset will use in your packaged project.</summary>
	public ulong CompressedMorphDataSizeInBytes;
	///<summary>The uncompressed memory usage of the morph targets. Please note that your packaged project will use the compressed amount of memory, and not the uncompresed amount of memory.</summary>
	public ulong UncompressedMorphDataSizeInBytes;
	///<summary>An array of integers where the first element is the most important morph target and the last element is the least important one.</summary>
	public TArray<int> MorphTargetErrorOrder;
	///<summary>An error value, for each morph target.</summary>
	public TArray<float> MorphTargetErrors;
	///<summary>The maximum absolute weight values of the morph targets, during training. One value for each morph target.</summary>
	public TArray<float> MaxMorphWeights;
	///<summary>The list of quality levels, where the first item represents the highest quality and the last element the lowest quality level.</summary>
	public TArray<FMLDeformerMorphModelQualityLevel> QualityLevels;
	///<summary>Include vertex normals in the morph targets?</summary>
	public bool bIncludeNormals;
	///<summary>Morph target delta values that are smaller than or equal to this threshold will be zeroed out.</summary>
	public float MorphDeltaZeroThreshold;
	///<summary>The morph target compression level. Higher values result in larger compression, but could result in visual artifacts.</summary>
	public float MorphCompressionLevel;
	///<summary>The channel data that represents the delta mask multipliers.</summary>
	public EMLDeformerMaskChannel MaskChannel;
	///<summary>Enable this if you want to invert the mask channel values. For example if you painted the neck seam vertices in red, and you wish the vertices that got painted to NOT move, you have to invert the mask.</summary>
	public bool bInvertMaskChannel;
}

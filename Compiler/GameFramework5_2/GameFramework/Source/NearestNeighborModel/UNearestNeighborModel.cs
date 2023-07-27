#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NearestNeighborModel.h")]
///<summary>The nearest neighbor model.</summary>
public partial class UNearestNeighborModel : UMLDeformerMorphModel {
// NearestNeighborModel
	public  int GetNumParts() { return default; }
	public  int GetPartNumVerts(int PartId) { return default; }
	public  int GetPCACoeffStart(int PartId) { return default; }
	public  int GetPCACoeffNum(int PartId) { return default; }
	public  int GetNumNeighbors(int PartId) { return default; }
	public  TArray<float> PCABasis(int PartId) { return default; }
	public  void SetPCABasis(int PartId,TArray<float> PCABasis) {}
	public  TArray<float> VertexMean(int PartId) { return default; }
	public  void SetVertexMean(int PartId,TArray<float> VertexMean) {}
	public  void SetNumNeighbors(int PartId,int InNumNeighbors) {}
	public  TArray<float> NeighborCoeffs(int PartId) { return default; }
	public  void SetNeighborCoeffs(int PartId,TArray<float> NeighborCoeffs) {}
	public  TArray<float> NeighborOffsets(int PartId) { return default; }
	public  void SetNeighborOffsets(int PartId,TArray<float> NeighborOffsets) {}
	public  TArray<float> ClipInputs(TArray<float> Input) { return default; }
	public  int GetInputDim() { return default; }
	public  TArray<int> GetHiddenLayerDims() { return default; }
	public  int GetOutputDim() { return default; }
	public  int GetNumEpochs() { return default; }
	public  int GetBatchSize() { return default; }
	public  float GetLearningRate() { return default; }
	public  TArray<FClothPartEditorData> GetClothPartEditorData() { return default; }
	public  TArray<FSkeletonCachePair> GetNearestNeighborData() { return default; }
	public  string GetModelDir() { return default; }
	public int InputDim;
	public TArray<int> HiddenLayerDims;
	public int OutputDim;
	public int NumEpochs;
	public int BatchSize;
	public float LearningRate;
	public bool bClothPartDataValid;
	public TArray<FClothPartEditorData> ClothPartEditorData;
	public int BasisSmoothIter;
	public bool bUseDualQuaternionDeltas;
	public bool bNearestNeighborDataValid;
	public bool bMorphTargetDataValid;
	public bool bUsePartOnlyMesh;
	public TArray<FSkeletonCachePair> NearestNeighborData;
	public float SavedNetworkSize;
	public float MorphDataSize;
	public bool bUseFileCache;
	public string FileCacheDirectory;
	public bool bRecomputeDeltas;
	public bool bRecomputePCA;
	public TArray<UAnimSequence> SourceAnims;
	public int NumClusters;
	public int KMeansPartId;
	public bool bUseInputMultipliers;
	public TArray<FVector3f> InputMultipliers;
	public TArray<FClothPartData> ClothPartData;
	public TArray<float> InputsMin;
	public TArray<float> InputsMax;
	public float DecayFactor;
	public float NearestNeighborOffsetWeight;
	public UNearestNeighborOptimizedNetwork OptimizedNetwork;
	public UNeuralNetwork NNINetwork;
	public bool bDoesMeetOptimizedNetworkPrerequisites;
	public bool bUseOptimizedNetwork;
}

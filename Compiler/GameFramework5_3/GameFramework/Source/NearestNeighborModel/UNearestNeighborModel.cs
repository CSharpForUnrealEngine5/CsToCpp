namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The nearest neighbor model.</summary>
[CppInclude("NearestNeighborModel.h")]
public partial class UNearestNeighborModel : UMLDeformerMorphModel {
	public static UClass StaticClass() {return default;}
	///<summary>GetNumParts</summary>
	public int GetNumParts() { return default; }
	///<summary>GetPartNumVerts</summary>
	public int GetPartNumVerts(int PartId) { return default; }
	///<summary>GetPCACoeffStart</summary>
	public int GetPCACoeffStart(int PartId) { return default; }
	///<summary>GetPCACoeffNum</summary>
	public int GetPCACoeffNum(int PartId) { return default; }
	///<summary>GetNumNeighbors</summary>
	public int GetNumNeighbors(int PartId) { return default; }
	///<summary>PCABasis</summary>
	public TArray<float> PCABasis(int PartId) { return default; }
	///<summary>SetPCABasis</summary>
	public void SetPCABasis(int PartId,TArray<float> PCABasis) {}
	///<summary>VertexMean</summary>
	public TArray<float> VertexMean(int PartId) { return default; }
	///<summary>SetVertexMean</summary>
	public void SetVertexMean(int PartId,TArray<float> VertexMean) {}
	///<summary>SetNumNeighbors</summary>
	public void SetNumNeighbors(int PartId,int InNumNeighbors) {}
	///<summary>NeighborCoeffs</summary>
	public TArray<float> NeighborCoeffs(int PartId) { return default; }
	///<summary>SetNeighborCoeffs</summary>
	public void SetNeighborCoeffs(int PartId,TArray<float> NeighborCoeffs) {}
	///<summary>NeighborOffsets</summary>
	public TArray<float> NeighborOffsets(int PartId) { return default; }
	///<summary>SetNeighborOffsets</summary>
	public void SetNeighborOffsets(int PartId,TArray<float> NeighborOffsets) {}
	///<summary>ClipInputs</summary>
	public TArray<float> ClipInputs(TArray<float> Input) { return default; }
	///<summary>GetInputDim</summary>
	public int GetInputDim() { return default; }
	///<summary>GetHiddenLayerDims</summary>
	public TArray<int> GetHiddenLayerDims() { return default; }
	///<summary>GetOutputDim</summary>
	public int GetOutputDim() { return default; }
	///<summary>GetNumEpochs</summary>
	public int GetNumEpochs() { return default; }
	///<summary>GetBatchSize</summary>
	public int GetBatchSize() { return default; }
	///<summary>GetLearningRate</summary>
	public float GetLearningRate() { return default; }
	///<summary>GetClothPartEditorData</summary>
	public TArray<FClothPartEditorData> GetClothPartEditorData() { return default; }
	///<summary>GetNearestNeighborData</summary>
	public TArray<FSkeletonCachePair> GetNearestNeighborData() { return default; }
	///<summary>GetModelDir</summary>
	public string GetModelDir() { return default; }
	///<summary>InputDim</summary>
	public int InputDim;
	///<summary>HiddenLayerDims</summary>
	public TArray<int> HiddenLayerDims;
	///<summary>OutputDim</summary>
	public int OutputDim;
	///<summary>NumEpochs</summary>
	public int NumEpochs;
	///<summary>BatchSize</summary>
	public int BatchSize;
	///<summary>LearningRate</summary>
	public float LearningRate;
	///<summary>bClothPartDataValid</summary>
	public bool bClothPartDataValid;
	///<summary>ClothPartEditorData</summary>
	public TArray<FClothPartEditorData> ClothPartEditorData;
	///<summary>BasisSmoothIter</summary>
	public int BasisSmoothIter;
	///<summary>bUseDualQuaternionDeltas</summary>
	public bool bUseDualQuaternionDeltas;
	///<summary>bNearestNeighborDataValid</summary>
	public bool bNearestNeighborDataValid;
	///<summary>bMorphTargetDataValid</summary>
	public bool bMorphTargetDataValid;
	///<summary>NearestNeighborData</summary>
	public TArray<FSkeletonCachePair> NearestNeighborData;
	///<summary>SavedNetworkSize</summary>
	public float SavedNetworkSize;
	///<summary>MorphDataSize</summary>
	public float MorphDataSize;
	///<summary>bUseFileCache</summary>
	public bool bUseFileCache;
	///<summary>FileCacheDirectory</summary>
	public string FileCacheDirectory;
	///<summary>bRecomputeDeltas</summary>
	public bool bRecomputeDeltas;
	///<summary>bRecomputePCA</summary>
	public bool bRecomputePCA;
	///<summary>SourceAnims</summary>
	public TArray<UAnimSequence> SourceAnims;
	///<summary>NumClusters</summary>
	public int NumClusters;
	///<summary>KMeansPartId</summary>
	public int KMeansPartId;
	///<summary>bUseInputMultipliers</summary>
	public bool bUseInputMultipliers;
	///<summary>InputMultipliers</summary>
	public TArray<FVector3f> InputMultipliers;
	///<summary>ClothPartData</summary>
	public TArray<FClothPartData> ClothPartData;
	///<summary>InputsMin</summary>
	public TArray<float> InputsMin;
	///<summary>InputsMax</summary>
	public TArray<float> InputsMax;
	///<summary>DecayFactor</summary>
	public float DecayFactor;
	///<summary>NearestNeighborOffsetWeight</summary>
	public float NearestNeighborOffsetWeight;
	///<summary>OptimizedNetwork</summary>
	public UNearestNeighborOptimizedNetwork OptimizedNetwork;
	///<summary>bUseOptimizedNetwork</summary>
	public bool bUseOptimizedNetwork;
}

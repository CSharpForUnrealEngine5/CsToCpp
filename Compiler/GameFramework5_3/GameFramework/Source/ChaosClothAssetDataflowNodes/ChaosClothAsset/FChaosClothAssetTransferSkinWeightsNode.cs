namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Transfer the skinning weights set on a skeletal mesh to the simulation and/or render mesh stored in the cloth collection.</summary>
[CppInclude("ChaosClothAsset/TransferSkinWeightsNode.h")]
public partial struct FChaosClothAssetTransferSkinWeightsNode {
	public FManagedArrayCollection Collection;
	public USkeletalMesh SkeletalMesh;
	public int LodIndex;
	public FTransform Transform;
	public EChaosClothAssetTransferSkinWeightsMethod TransferMethod;
	public double RadiusPercentage;
	public double NormalThreshold;
	public bool LayeredMeshSupport;
	public int NumSmoothingIterations;
	public float SmoothingStrength;
	public FChaosClothAssetWeightedValueNonAnimatableNoLowHighRange InpaintMask;
	public FManagedArrayCollection TransferWeightsCollection;
}

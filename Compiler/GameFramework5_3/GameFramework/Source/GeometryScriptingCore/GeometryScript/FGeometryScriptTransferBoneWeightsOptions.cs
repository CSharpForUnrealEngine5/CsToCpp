namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshBoneWeightFunctions.h")]
public partial struct FGeometryScriptTransferBoneWeightsOptions {
	public ETransferBoneWeightsMethod TransferMethod;
	public EOutputTargetMeshBones OutputTargetMeshBones;
	public FGeometryScriptBoneWeightProfile SourceProfile;
	public FGeometryScriptBoneWeightProfile TargetProfile;
	public double RadiusPercentage;
	public double NormalThreshold;
	public bool LayeredMeshSupport;
	public int NumSmoothingIterations;
	public float SmoothingStrength;
	public FName InpaintMask;
}

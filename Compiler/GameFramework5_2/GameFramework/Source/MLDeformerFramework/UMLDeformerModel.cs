#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerModel.h")]
///<summary>The ML Deformer runtime model base class.</summary>
public partial class UMLDeformerModel : UObject {
// MLDeformerModel
	public int NumBaseMeshVerts;
	public int NumTargetMeshVerts;
	public UMLDeformerInputInfo InputInfo;
	public TArray<int> VertexMap;
	public USkeletalMesh SkeletalMesh;
	public UMLDeformerVizSettings VizSettings;
	public bool bIncludeBones;
	public bool bIncludeCurves;
	public TSoftObjectPtr<UAnimSequence> AnimSequence;
	public FTransform AlignmentTransform;
	public TArray<FBoneReference> BoneIncludeList;
	public TArray<FMLDeformerCurveReference> CurveIncludeList;
	public int MaxTrainingFrames;
	public float DeltaCutoffLength;
}

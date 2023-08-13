namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The ML Deformer runtime model base class.</summary>
[CppInclude("MLDeformerModel.h")]
public partial class UMLDeformerModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Cached number of skeletal mesh vertices.</summary>
	public int NumBaseMeshVerts;
	///<summary>Cached number of target mesh vertices.</summary>
	public int NumTargetMeshVerts;
	///<summary>The information about the neural network inputs. This contains things such as bone names and curve names.</summary>
	public UMLDeformerInputInfo InputInfo;
	///<summary>This is an index per vertex in the mesh, indicating the imported vertex number from the source asset.</summary>
	public TArray<int> VertexMap;
	///<summary>The skeletal mesh that represents the linear skinned mesh.</summary>
	public USkeletalMesh SkeletalMesh;
	///<summary>VizSettings</summary>
	public UMLDeformerVizSettings VizSettings;
	///<summary>Specifies whether bone transformations should be included as inputs during the training process.</summary>
	public bool bIncludeBones;
	///<summary>Specifies whether curve values (a float per curve) should be included as inputs during the training process.</summary>
	public bool bIncludeCurves;
	///<summary>The animation sequence to apply to the base mesh. This has to match the animation of the target mesh&#39;s geometry cache.</summary>
	public TSoftObjectPtr<UAnimSequence> AnimSequence;
	///<summary>The transform that aligns the Geometry Cache to the SkeletalMesh. This will mostly apply some scale and a rotation, but no translation.</summary>
	public FTransform AlignmentTransform;
	///<summary>The bones to include during training. When none are provided, all bones of the Skeleton will be included.</summary>
	public TArray<FBoneReference> BoneIncludeList;
	///<summary>The curves to include during training. When none are provided, all curves of the Skeleton will be included.</summary>
	public TArray<FMLDeformerCurveReference> CurveIncludeList;
	///<summary>The maximum numer of training frames (samples) to train on. Use this to train on a sub-section of your full training data.</summary>
	public int MaxTrainingFrames;
	///<summary>Sometimes there can be some vertices that cause some issues that cause deltas to be very long. We can ignore these deltas by setting a cutoff value.</summary>
	public float DeltaCutoffLength;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>API used to modify skin weights on a Skeletal Mesh asset.</summary>
[CppInclude("SkinWeightModifier.h")]
public partial class USkinWeightModifier : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Call this first to load the weights for a skeletal mesh for fast editing.</summary>
	public bool SetSkeletalMesh(USkeletalMesh InMesh) { return default; }
	///<summary>Actually applies the weight modifications to the skeletal mesh. This action creates an undo transaction.</summary>
	public bool CommitWeightsToSkeletalMesh() { return default; }
	///<summary>Get a reference to the skeletal mesh that was loaded</summary>
	public USkeletalMesh GetSkeletalMesh() { return default; }
	///<summary>Get the total number of vertices in the skeletal mesh.</summary>
	public int GetNumVertices() { return default; }
	///<summary>Get an array of all bone names in the skeletal mesh.</summary>
	public TArray<FName> GetAllBoneNames() { return default; }
	///<summary>Get all bone weights for a single vertex.</summary>
	public TMap<FName,float> GetVertexWeights(int VertexID) { return default; }
	///<summary>Set bone weights for a single vertex. The weights are stored as supplied and not normalized until</summary>
	public bool SetVertexWeights(int VertexID,TMap<FName,float> InWeights,bool bReplaceAll/*=false*/) { return default; }
	///<summary>Normalize weights on the specified vertex.</summary>
	public bool NormalizeVertexWeights(int VertexID) { return default; }
	///<summary>Normalize weights on all vertices in the mesh.</summary>
	public bool NormalizeAllWeights() { return default; }
	///<summary>Strips out smallest influences to ensure each vertex does not have weight on more influences than MaxInfluences.</summary>
	public bool EnforceMaxInfluences(int MaxInfluences/*=-1*/) { return default; }
	///<summary>Remove all weights below the given threshold value, on the given vertex.</summary>
	public bool PruneVertexWeights(int VertexID,float WeightThreshold) { return default; }
	///<summary>Remove all weights below the given threshold value, on all vertices.</summary>
	public bool PruneAllWeights(float WeightThreshold) { return default; }
	///<summary>the skeletal mesh that was loaded by SetSkeletalMesh</summary>
	public USkeletalMesh Mesh;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The training model for the neural morph model.</summary>
[CppInclude("NeuralMorphTrainingModel.h")]
public partial class UNeuralMorphTrainingModel : UMLDeformerTrainingModel {
	public static UClass StaticClass() {return default;}
	///<summary>Main training function, with implementation in python.</summary>
	public int Train() { return default; }
	///<summary>GetNumBoneGroups</summary>
	public int GetNumBoneGroups() { return default; }
	///<summary>GetNumCurveGroups</summary>
	public int GetNumCurveGroups() { return default; }
	///<summary>GenerateBoneGroupIndices</summary>
	public TArray<int> GenerateBoneGroupIndices() { return default; }
	///<summary>GenerateCurveGroupIndices</summary>
	public TArray<int> GenerateCurveGroupIndices() { return default; }
	///<summary>GetMorphTargetMasks</summary>
	public TArray<float> GetMorphTargetMasks() { return default; }
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The training model for the neural morph model.</summary>
[CppInclude("NeuralMorphTrainingModel.h")]
public partial class UNeuralMorphTrainingModel : UMLDeformerTrainingModel {
	///<summary>Main training function, with implementation in python.</summary>
	public  int Train() { return default; }
	///<summary>GetNumBoneGroups</summary>
	public  int GetNumBoneGroups() { return default; }
	///<summary>GetNumCurveGroups</summary>
	public  int GetNumCurveGroups() { return default; }
	///<summary>GenerateBoneGroupIndices</summary>
	public  TArray<int> GenerateBoneGroupIndices() { return default; }
	///<summary>GenerateCurveGroupIndices</summary>
	public  TArray<int> GenerateCurveGroupIndices() { return default; }
}

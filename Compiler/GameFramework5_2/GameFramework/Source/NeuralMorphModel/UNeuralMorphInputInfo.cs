#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralMorphInputInfo.h")]
///<summary>The neural morph model's input info that contains all the data about the inputs to the network.</summary>
public partial class UNeuralMorphInputInfo : UMLDeformerInputInfo {
// NeuralMorphInputInfo
	public TArray<FNeuralMorphBoneGroup> BoneGroups;
	public TArray<FNeuralMorphCurveGroup> CurveGroups;
}

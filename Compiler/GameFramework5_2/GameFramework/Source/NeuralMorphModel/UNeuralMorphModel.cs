#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NeuralMorphModel.h")]
///<summary>The neural morph model.</summary>
public partial class UNeuralMorphModel : UMLDeformerMorphModel {
// NeuralMorphModel
	public TArray<FNeuralMorphBoneGroup> BoneGroups;
	public TArray<FNeuralMorphCurveGroup> CurveGroups;
	public ENeuralMorphMode Mode;
	public int LocalNumMorphTargetsPerBone;
	public int GlobalNumMorphTargets;
	public int NumIterations;
	public int LocalNumHiddenLayers;
	public int LocalNumNeuronsPerLayer;
	public int GlobalNumHiddenLayers;
	public int GlobalNumNeuronsPerLayer;
	public int BatchSize;
	public float LearningRate;
	public float LearningRateDecay;
	public float RegularizationFactor;
	public UNeuralMorphNetwork NeuralMorphNetwork;
}

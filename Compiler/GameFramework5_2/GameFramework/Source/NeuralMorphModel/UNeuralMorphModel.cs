#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The neural morph model.</summary>
[CppInclude("NeuralMorphModel.h")]
public partial class UNeuralMorphModel : UMLDeformerMorphModel {
	///<summary>The set of bones that are grouped together and generate morph targets together as a whole.</summary>
	public TArray<FNeuralMorphBoneGroup> BoneGroups;
	///<summary>The set of curves that are grouped together and generate morph targets together as a whole.</summary>
	public TArray<FNeuralMorphCurveGroup> CurveGroups;
	///<summary>The mode that the neural network will operate in.</summary>
	public ENeuralMorphMode Mode;
	///<summary>The number of morph targets to generate per bone, curve or group.</summary>
	public int LocalNumMorphTargetsPerBone;
	///<summary>The number of morph targets to generate in total.</summary>
	public int GlobalNumMorphTargets;
	///<summary>The number of iterations to train the model for.</summary>
	public int NumIterations;
	///<summary>The number of hidden layers that the neural network model will have.</summary>
	public int LocalNumHiddenLayers;
	///<summary>The number of units/neurons per hidden layer.</summary>
	public int LocalNumNeuronsPerLayer;
	///<summary>The number of hidden layers that the neural network model will have.\nHigher numbers will slow down performance but can deal with more complex deformations.</summary>
	public int GlobalNumHiddenLayers;
	///<summary>The number of units/neurons per hidden layer. Higher numbers will slow down performance but allow for more complex mesh deformations.</summary>
	public int GlobalNumNeuronsPerLayer;
	///<summary>The number of frames per batch when training the model.</summary>
	public int BatchSize;
	///<summary>The learning rate used during the model training.</summary>
	public float LearningRate;
	///<summary>The learning rate decay rate. If this is set to 1, the learning rate will not change.</summary>
	public float LearningRateDecay;
	///<summary>The regularization factor. Higher values can help generate more sparse morph targets, but can also lead to visual artifacts.</summary>
	public float RegularizationFactor;
	///<summary>The neural morph model network.</summary>
	public UNeuralMorphNetwork NeuralMorphNetwork;
}

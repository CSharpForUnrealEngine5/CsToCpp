namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The neural morph model.</summary>
[CppInclude("NeuralMorphModel.h")]
public partial class UNeuralMorphModel : UMLDeformerMorphModel {
	public static UClass StaticClass() {return default;}
	///<summary>The set of bones that are grouped together and generate morph targets together as a whole.</summary>
	public TArray<FNeuralMorphBoneGroup> BoneGroups;
	///<summary>The set of curves that are grouped together and generate morph targets together as a whole.</summary>
	public TArray<FNeuralMorphCurveGroup> CurveGroups;
	///<summary>Information needed to generate a mask for each bone.</summary>
	public TMap<FName,FNeuralMorphMaskInfo> BoneMaskInfos;
	///<summary>Information needed to generate a mask for each bone group.</summary>
	public TMap<FName,FNeuralMorphMaskInfo> BoneGroupMaskInfos;
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
	///<summary>The regularization factor. Higher values can help generate more sparse morph targets, but can also lead to visual artifacts.</summary>
	public float RegularizationFactor;
	///<summary>Enable the use of per bone and bone group masks.</summary>
	public bool bEnableBoneMasks;
	///<summary>The beta parameter in the smooth L1 loss function, which describes below which absolute error to use a squared term. If the error is above or equal to this beta value, it will use the L1 loss.</summary>
	public float SmoothLossBeta;
	///<summary>The neural morph model network.</summary>
	public UNeuralMorphNetwork NeuralMorphNetwork;
}

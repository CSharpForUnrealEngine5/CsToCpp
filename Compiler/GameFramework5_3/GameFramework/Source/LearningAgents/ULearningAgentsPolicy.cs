namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A policy that maps from observations to actions for the managed agents.</summary>
[CppInclude("LearningAgentsPolicy.h")]
public partial class ULearningAgentsPolicy : ULearningAgentsManagerComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes this object to be used with the given agent interactor and policy settings.</summary>
	public void SetupPolicy(ULearningAgentsInteractor InInteractor,FLearningAgentsPolicySettings PolicySettings/*=new FLearningAgentsPolicySettings()*/,ULearningAgentsNeuralNetwork NeuralNetworkAsset/*=nullptr*/) {}
	///<summary>Load a snapshot&#39;s weights into this policy.</summary>
	public void LoadPolicyFromSnapshot(FFilePath File) {}
	///<summary>Save this policy&#39;s weights into a snapshot.</summary>
	public void SavePolicyToSnapshot(FFilePath File) {}
	///<summary>Use a ULearningAgentsNeuralNetwork asset directly for this critic rather than making a copy. If used</summary>
	public void UsePolicyFromAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
	///<summary>Load a ULearningAgentsNeuralNetwork asset&#39;s weights into this policy.</summary>
	public void LoadPolicyFromAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
	///<summary>Save this policy&#39;s weights to a ULearningAgentsNeuralNetwork asset.</summary>
	public void SavePolicyToAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
	///<summary>Calling this function will run the underlying neural network on the previously buffered observations to populate</summary>
	public void EvaluatePolicy() {}
	///<summary>Calls EncodeObservations, followed by EvaluatePolicy, followed by DecodeActions</summary>
	public void RunInference() {}
	///<summary>Get the action noise scale used.</summary>
	public float GetActionNoiseScale() { return default; }
	///<summary>Set the action noise scale used.</summary>
	public void SetActionNoiseScale(float ActionNoiseScale) {}
	///<summary>The agent interactor this policy is associated with.</summary>
	public ULearningAgentsInteractor Interactor;
	///<summary>The underlying neural network.</summary>
	public ULearningAgentsNeuralNetwork Network;
}

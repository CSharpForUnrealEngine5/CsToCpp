namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A critic used by some algorithms for training the managed agents.</summary>
[CppInclude("LearningAgentsCritic.h")]
public partial class ULearningAgentsCritic : ULearningAgentsManagerComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Initializes this object to be used with the given agent interactor and critic settings.</summary>
	public void SetupCritic(ULearningAgentsInteractor InInteractor,FLearningAgentsCriticSettings CriticSettings/*=new FLearningAgentsCriticSettings()*/,ULearningAgentsNeuralNetwork NeuralNetworkAsset/*=nullptr*/) {}
	///<summary>Load a snapshot&#39;s weights into this critic.</summary>
	public void LoadCriticFromSnapshot(FFilePath File) {}
	///<summary>Save this critic&#39;s weights into a snapshot.</summary>
	public void SaveCriticToSnapshot(FFilePath File) {}
	///<summary>Use a ULearningAgentsNeuralNetwork asset directly for this critic rather than making a copy. If used</summary>
	public void UseCriticFromAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
	///<summary>Load a ULearningAgentsNeuralNetwork asset&#39;s weights into this critic.</summary>
	public void LoadCriticFromAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
	///<summary>Save this critic&#39;s weights to a ULearningAgentsNeuralNetwork asset.</summary>
	public void SaveCriticToAsset(ULearningAgentsNeuralNetwork NeuralNetworkAsset) {}
	///<summary>Calling this function will run the underlying neural network on the previously buffered observations to populate</summary>
	public void EvaluateCritic() {}
	///<summary>Gets an estimate of the average discounted return expected by an agent according to the critic. I.E. the total</summary>
	public float GetEstimatedDiscountedReturn(int AgentId) { return default; }
	///<summary>The agent interactor this critic is associated with.</summary>
	public ULearningAgentsInteractor Interactor;
	///<summary>The underlying neural network.</summary>
	public ULearningAgentsNeuralNetwork Network;
}

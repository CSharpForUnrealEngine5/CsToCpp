namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The configurable settings for a ULearningAgentsCritic.</summary>
[CppInclude("LearningAgentsCritic.h")]
public partial struct FLearningAgentsCriticSettings {
	public int LayerNum;
	public int HiddenLayerSize;
	public ELearningAgentsActivationFunction ActivationFunction;
}

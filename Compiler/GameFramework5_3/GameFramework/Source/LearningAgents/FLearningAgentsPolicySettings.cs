namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The configurable settings for a ULearningAgentsPolicy.</summary>
[CppInclude("LearningAgentsPolicy.h")]
public partial struct FLearningAgentsPolicySettings {
	public int ActionNoiseSeed;
	public float ActionNoiseMin;
	public float ActionNoiseMax;
	public float ActionNoiseScale;
	public int LayerNum;
	public int HiddenLayerSize;
	public ELearningAgentsActivationFunction ActivationFunction;
}

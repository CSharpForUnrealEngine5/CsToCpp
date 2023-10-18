namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The configurable game settings for a ULearningAgentsTrainer. These allow the timestep and physics tick to be fixed</summary>
[CppInclude("LearningAgentsTrainer.h")]
public partial struct FLearningAgentsTrainerGameSettings {
	public bool bUseFixedTimeStep;
	public float FixedTimeStepFrequency;
	public bool bSetMaxPhysicsStepToFixedTimeStep;
	public bool bDisableVSync;
	public bool bUseUnlitViewportRendering;
}

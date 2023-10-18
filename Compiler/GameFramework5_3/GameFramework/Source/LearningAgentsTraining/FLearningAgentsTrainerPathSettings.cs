namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The path settings for the trainer.</summary>
[CppInclude("LearningAgentsTrainer.h")]
public partial struct FLearningAgentsTrainerPathSettings {
	public FDirectoryPath EditorEngineRelativePath;
	public string NonEditorEngineRelativePath;
	public FDirectoryPath IntermediateRelativePath;
}

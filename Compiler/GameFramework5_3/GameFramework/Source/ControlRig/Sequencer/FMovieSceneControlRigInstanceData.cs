namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigInstanceData.h")]
public partial struct FMovieSceneControlRigInstanceData {
	public bool bAdditive;
	public bool bApplyBoneFilter;
	public FInputBlendPose BoneFilter;
	public FMovieSceneFloatChannel Weight;
	public FMovieSceneEvaluationOperand Operand;
}

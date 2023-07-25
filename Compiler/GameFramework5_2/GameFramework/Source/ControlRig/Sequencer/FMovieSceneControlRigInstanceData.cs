#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigInstanceData.h")]
public partial struct FMovieSceneControlRigInstanceData {
// MovieSceneControlRigInstanceData
	public bool bAdditive;
	public bool bApplyBoneFilter;
	public FInputBlendPose BoneFilter;
	public FMovieSceneFloatChannel Weight;
	public FMovieSceneEvaluationOperand Operand;
}

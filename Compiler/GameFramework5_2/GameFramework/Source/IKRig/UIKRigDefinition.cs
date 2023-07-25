#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDefinition.h")]
public partial class UIKRigDefinition : UObject {
// IKRigDefinition
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	public float BoneSize;
	public bool DrawGoals;
	public float GoalSize;
	public float GoalThickness;
	public UObject Controller;
	public FIKRigSkeleton Skeleton;
	public TArray<UIKRigEffectorGoal> Goals;
	public TArray<UIKRigSolver> Solvers;
	public FRetargetDefinition RetargetDefinition;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IKRigDefinition.h")]
public partial class UIKRigDefinition : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The skeletal mesh to run the IK solve on (loaded into viewport).</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewSkeletalMesh;
	///<summary>The size of the Bones in the editor viewport. This is set by callbacks from the viewport Character&gt;Bones menu</summary>
	public float BoneSize;
	///<summary>Draw bones in the viewport.</summary>
	public bool DrawGoals;
	///<summary>The size of the Goals in the editor viewport.</summary>
	public float GoalSize;
	///<summary>The thickness of the Goals in the editor viewport.</summary>
	public float GoalThickness;
	///<summary>The controller responsible for managing this asset&#39;s data (all editor mutation goes through this)</summary>
	public UObject Controller;
	///<summary>hierarchy and bone-pose transforms</summary>
	public FIKRigSkeleton Skeleton;
	///<summary>goals, used as effectors by solvers that support them</summary>
	public TArray<UIKRigEffectorGoal> Goals;
	///<summary>polymorphic stack of solvers, executed in serial fashion where output of prior solve is input to the next</summary>
	public TArray<UIKRigSolver> Solvers;
	///<summary>bone chains for IK Retargeter</summary>
	public FRetargetDefinition RetargetDefinition;
}

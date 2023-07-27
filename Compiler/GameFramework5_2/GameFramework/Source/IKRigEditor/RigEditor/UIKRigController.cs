#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigEditor/IKRigController.h")]
///<summary>A singleton (per-asset) class used to make modifications to a UIKRigDefinition asset</summary>
public partial class UIKRigController : UObject {
// IKRigController
	public static UIKRigController GetController(UIKRigDefinition InIKRigDefinition) { return default; }
	public  bool SetSkeletalMesh(USkeletalMesh SkeletalMesh,bool bTransact/*=false*/) { return default; }
	public  USkeletalMesh GetSkeletalMesh() { return default; }
	public  bool IsSkeletalMeshCompatible(USkeletalMesh SkeletalMeshToCheck) { return default; }
	public  int AddSolver(UClass InSolverClass) { return default; }
	public  bool RemoveSolver(int SolverIndex) { return default; }
	public  UIKRigSolver GetSolverAtIndex(int Index) { return default; }
	public  int GetIndexOfSolver(UIKRigSolver Solver) { return default; }
	public  int GetNumSolvers() { return default; }
	public  bool MoveSolverInStack(int SolverToMoveIndex,int TargetSolverIndex) { return default; }
	public  bool SetSolverEnabled(int SolverIndex,bool bIsEnabled) { return default; }
	public  bool GetSolverEnabled(int SolverIndex) { return default; }
	public  bool SetRootBone(string RootBoneName,int SolverIndex) { return default; }
	public  string GetRootBone(int SolverIndex) { return default; }
	public  bool SetEndBone(string EndBoneName,int SolverIndex) { return default; }
	public  string GetEndBone(int SolverIndex) { return default; }
	public  string AddNewGoal(string GoalName,string BoneName) { return default; }
	public  bool RemoveGoal(string GoalName) { return default; }
	public  string RenameGoal(string OldName,string PotentialNewName) { return default; }
	public  bool SetGoalBone(string GoalName,string NewBoneName) { return default; }
	public  string GetBoneForGoal(string GoalName) { return default; }
	public  string GetGoalNameForBone(string BoneName) { return default; }
	public  bool ConnectGoalToSolver(string GoalName,int SolverIndex) { return default; }
	public  bool DisconnectGoalFromSolver(string GoalToRemove,int SolverIndex) { return default; }
	public  bool IsGoalConnectedToSolver(string GoalName,int SolverIndex) { return default; }
	public  bool IsGoalConnectedToAnySolver(string GoalName) { return default; }
	public  UIKRigEffectorGoal GetGoal(string GoalName) { return default; }
	public  TArray<UIKRigEffectorGoal> GetAllGoals() { return default; }
	public  UObject GetGoalSettingsForSolver(string GoalName,int SolverIndex) { return default; }
	public  bool SetBoneExcluded(string BoneName,bool bExclude) { return default; }
	public  bool GetBoneExcluded(string BoneName) { return default; }
	public  bool AddBoneSetting(string BoneName,int SolverIndex) { return default; }
	public  bool RemoveBoneSetting(string BoneName,int SolverIndex) { return default; }
	public  UObject GetBoneSettings(string BoneName,int SolverIndex) { return default; }
	public  FTransform GetRefPoseTransformOfBone(string BoneName) { return default; }
	public  string AddRetargetChain(string ChainName,string StartBoneName,string EndBoneName,string GoalName) { return default; }
	public  bool RemoveRetargetChain(string ChainName) { return default; }
	public  string RenameRetargetChain(string ChainName,string NewChainName) { return default; }
	public  bool SetRetargetChainStartBone(string ChainName,string StartBoneName) { return default; }
	public  bool SetRetargetChainEndBone(string ChainName,string EndBoneName) { return default; }
	public  bool SetRetargetChainGoal(string ChainName,string GoalName) { return default; }
	public  string GetRetargetChainGoal(string ChainName) { return default; }
	public  string GetRetargetChainStartBone(string ChainName) { return default; }
	public  string GetRetargetChainEndBone(string ChainName) { return default; }
	public  TArray<FBoneChain> GetRetargetChains() { return default; }
	public  bool SetRetargetRoot(string RootBoneName) { return default; }
	public  string GetRetargetRoot() { return default; }
	public UIKRigDefinition Asset;
}

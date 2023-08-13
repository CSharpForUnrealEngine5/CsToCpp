namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A singleton (per-asset) class used to make modifications to a UIKRigDefinition asset</summary>
[CppInclude("RigEditor/IKRigController.h")]
public partial class UIKRigController : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Use this to get the controller for the given IKRig</summary>
	public static UIKRigController GetController(UIKRigDefinition InIKRigDefinition) { return default; }
	///<summary>Sets the preview mesh to use. Loads the hierarchy into the asset&#39;s IKRigSkeleton.</summary>
	public bool SetSkeletalMesh(USkeletalMesh SkeletalMesh,bool bTransact/*=false*/) { return default; }
	///<summary>Get the skeletal mesh this asset is initialized with</summary>
	public USkeletalMesh GetSkeletalMesh() { return default; }
	///<summary>Returns true if the provided skeletal mesh could be used with this IK Rig.</summary>
	public bool IsSkeletalMeshCompatible(USkeletalMesh SkeletalMeshToCheck) { return default; }
	///<summary>Add a new solver of the given type to the bottom of the stack. Returns the stack index.</summary>
	public int AddSolver(UClass InSolverClass) { return default; }
	///<summary>Remove the solver at the given stack index.</summary>
	public bool RemoveSolver(int SolverIndex) { return default; }
	///<summary>Get access to the given solver.</summary>
	public UIKRigSolver GetSolverAtIndex(int Index) { return default; }
	///<summary>Get access to the given solver.</summary>
	public int GetIndexOfSolver(UIKRigSolver Solver) { return default; }
	///<summary>Get the number of solvers in the stack.</summary>
	public int GetNumSolvers() { return default; }
	///<summary>Move the solver at the given index to the target index.</summary>
	public bool MoveSolverInStack(int SolverToMoveIndex,int TargetSolverIndex) { return default; }
	///<summary>Set enabled/disabled status of the given solver.</summary>
	public bool SetSolverEnabled(int SolverIndex,bool bIsEnabled) { return default; }
	///<summary>Get enabled status of the given solver.</summary>
	public bool GetSolverEnabled(int SolverIndex) { return default; }
	///<summary>Set the root bone on a given solver. (not all solvers support root bones, checks CanSetRootBone() first)</summary>
	public bool SetRootBone(string RootBoneName,int SolverIndex) { return default; }
	///<summary>Get the name of the root bone on a given solver. (not all solvers support root bones, checks CanSetRootBone() first)</summary>
	public string GetRootBone(int SolverIndex) { return default; }
	///<summary>Set the end bone on a given solver. (not all solvers require extra end bones, checks CanSetEndBone() first)</summary>
	public bool SetEndBone(string EndBoneName,int SolverIndex) { return default; }
	///<summary>Get the name of the end bone on a given solver. (not all solvers require extra end bones, checks CanSetEndBone() first)</summary>
	public string GetEndBone(int SolverIndex) { return default; }
	///<summary>Add a new Goal associated with the given Bone. GoalName must be unique. Bones can have multiple Goals (rare).</summary>
	public string AddNewGoal(string GoalName,string BoneName) { return default; }
	///<summary>Remove the Goal by name.</summary>
	public bool RemoveGoal(string GoalName) { return default; }
	///<summary>Rename a Goal. Returns new name, which may be different after being sanitized. Returns NAME_None if this fails.</summary>
	public string RenameGoal(string OldName,string PotentialNewName) { return default; }
	///<summary>The the Bone that the given Goal should be parented to / associated with.</summary>
	public bool SetGoalBone(string GoalName,string NewBoneName) { return default; }
	///<summary>The the Bone associated with the given Goal.</summary>
	public string GetBoneForGoal(string GoalName) { return default; }
	///<summary>Get the Goal associated with the given Bone (may be NAME_None)</summary>
	public string GetGoalNameForBone(string BoneName) { return default; }
	///<summary>Connect the given Goal to the given Solver. This creates an &quot;Effector&quot; with settings specific to this Solver.</summary>
	public bool ConnectGoalToSolver(string GoalName,int SolverIndex) { return default; }
	///<summary>Disconnect the given Goal from the given Solver. This removes the Effector that associates the Goal with the Solver.</summary>
	public bool DisconnectGoalFromSolver(string GoalToRemove,int SolverIndex) { return default; }
	///<summary>Returns true if the given Goal is connected to the given Solver. False otherwise.</summary>
	public bool IsGoalConnectedToSolver(string GoalName,int SolverIndex) { return default; }
	///<summary>Returns true if the given Goal is connected to ANY solver. False otherwise.</summary>
	public bool IsGoalConnectedToAnySolver(string GoalName) { return default; }
	///<summary>Get read-write access to the Goal with the given name.</summary>
	public UIKRigEffectorGoal GetGoal(string GoalName) { return default; }
	///<summary>Get access to the list of Goals.</summary>
	public TArray<UIKRigEffectorGoal> GetAllGoals() { return default; }
	///<summary>Get the UObject for the settings associated with the given Goal in the given Solver.</summary>
	public UObject GetGoalSettingsForSolver(string GoalName,int SolverIndex) { return default; }
	///<summary>Include/exclude a bone from all the solvers. All bones are included by default.</summary>
	public bool SetBoneExcluded(string BoneName,bool bExclude) { return default; }
	///<summary>Returns true if the given Bone is excluded, false otherwise.</summary>
	public bool GetBoneExcluded(string BoneName) { return default; }
	///<summary>Add settings to the given Bone/Solver. Does nothing if Bone already has settings in this Solver.</summary>
	public bool AddBoneSetting(string BoneName,int SolverIndex) { return default; }
	///<summary>Remove settings for the given Bone/Solver. Does nothing if Bone doesn&#39;t have setting in this Solver.</summary>
	public bool RemoveBoneSetting(string BoneName,int SolverIndex) { return default; }
	///<summary>Get the generic (Solver-specific) Bone settings UObject for this Bone in the given Solver.</summary>
	public UObject GetBoneSettings(string BoneName,int SolverIndex) { return default; }
	///<summary>Get the global-space retarget pose transform of the given Bone.</summary>
	public FTransform GetRefPoseTransformOfBone(string BoneName) { return default; }
	///<summary>Add a new chain with the given Chain and Bone names. Returns newly created chain name (uniquified).</summary>
	public string AddRetargetChain(string ChainName,string StartBoneName,string EndBoneName,string GoalName) { return default; }
	///<summary>Remove a Chain with the given name. Returns true if a Chain was removed.</summary>
	public bool RemoveRetargetChain(string ChainName) { return default; }
	///<summary>Renamed the given Chain. Returns the new name (same as old if unsuccessful).</summary>
	public string RenameRetargetChain(string ChainName,string NewChainName) { return default; }
	///<summary>Set the Start Bone for the given Chain. Returns true if operation was successful.</summary>
	public bool SetRetargetChainStartBone(string ChainName,string StartBoneName) { return default; }
	///<summary>Set the End Bone for the given Chain. Returns true if operation was successful.</summary>
	public bool SetRetargetChainEndBone(string ChainName,string EndBoneName) { return default; }
	///<summary>Set the Goal for the given Chain. Returns true if operation was successful.</summary>
	public bool SetRetargetChainGoal(string ChainName,string GoalName) { return default; }
	///<summary>Get the Goal name for the given Chain.</summary>
	public string GetRetargetChainGoal(string ChainName) { return default; }
	///<summary>Get the End Bone name for the given Chain.</summary>
	public string GetRetargetChainStartBone(string ChainName) { return default; }
	///<summary>Get the Start Bone name for the given Chain.</summary>
	public string GetRetargetChainEndBone(string ChainName) { return default; }
	///<summary>Get read-only access to the list of Chains.</summary>
	public TArray<FBoneChain> GetRetargetChains() { return default; }
	///<summary>Set the Root Bone of the retargeting (can only be one).</summary>
	public bool SetRetargetRoot(string RootBoneName) { return default; }
	///<summary>Get the name of the Root Bone of the retargeting (can only be one).</summary>
	public string GetRetargetRoot() { return default; }
	///<summary>The actual IKRigDefinition asset that this Controller modifies.</summary>
	public UIKRigDefinition Asset;
}

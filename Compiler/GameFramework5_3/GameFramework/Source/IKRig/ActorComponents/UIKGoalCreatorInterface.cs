namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorComponents/IKRigInterface.h")]
public partial class UIKGoalCreatorInterface : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Add your own goals to the OutGoals map (careful not to remove existing goals in the map!)</summary>
	public void AddIKGoals(TMap<FName,FIKRigGoal> OutGoals) {}
}

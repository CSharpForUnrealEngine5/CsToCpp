#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorComponents/IKRigInterface.h")]
public partial class UIKGoalCreatorInterface : UInterface {
	///<summary>Add your own goals to the OutGoals map (careful not to remove existing goals in the map!)</summary>
	public  void AddIKGoals(TMap<string,FIKRigGoal> OutGoals) {}
}

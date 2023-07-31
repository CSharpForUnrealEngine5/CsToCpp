#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FAITestSpawnInfo</summary>
[CppInclude("FunctionalAITest.h")]
public partial struct FAITestSpawnInfo {
	public UClass PawnClass;
	public UClass ControllerClass;
	public FGenericTeamId TeamID;
	public UBehaviorTree BehaviorTree;
}

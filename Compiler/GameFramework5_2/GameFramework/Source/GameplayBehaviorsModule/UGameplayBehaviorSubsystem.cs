namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorSubsystem.h")]
public partial class UGameplayBehaviorSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>AgentGameplayBehaviors</summary>
	public TMap<AActor,FAgentGameplayBehaviors> AgentGameplayBehaviors;
}

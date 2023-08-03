#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorSubsystem.h")]
public partial class UGameplayBehaviorSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>AgentGameplayBehaviors</summary>
	public TMap<AActor,FAgentGameplayBehaviors> AgentGameplayBehaviors;
}

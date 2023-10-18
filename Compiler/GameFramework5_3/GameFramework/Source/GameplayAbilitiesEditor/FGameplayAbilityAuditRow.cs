namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This contains all of the data we gather about a Blueprint during the Audit process</summary>
[CppInclude("GameplayAbilityAudit.h")]
public partial struct FGameplayAbilityAuditRow {
	public EGameplayAbilityActivationPath ActivationPath;
	public EGameplayAbilityNetExecutionPolicy NetExecutionPolicy;
	public EGameplayAbilityNetSecurityPolicy NetSecurityPolicy;
	public EGameplayAbilityReplicationPolicy ReplicationPolicy;
	public FName CostGE;
	public FName CooldownGE;
	public bool bOverridesCanActivate;
	public bool bOverridesShouldAbilityRespondToEvent;
	public bool bChecksCostManually;
	public bool bCommitAbility;
	public EGameplayAbilityEndInBlueprints EndAbility;
	public TArray<FName> Functions;
	public TArray<string> AsyncTasks;
	public TArray<FName> MutatedVariables;
}

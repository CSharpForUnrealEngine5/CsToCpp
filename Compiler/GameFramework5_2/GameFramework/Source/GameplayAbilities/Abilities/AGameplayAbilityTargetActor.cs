#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TargetActors are spawned to assist with ability targeting. They are spawned by ability tasks and create/determine the outgoing targeting data passed from one task to another</summary>
[CppInclude("Abilities/GameplayAbilityTargetActor.h")]
public partial class AGameplayAbilityTargetActor : AActor {
	///<summary>The TargetData this class produces can be entirely generated on the server. We don&#39;t require the client to send us full or partial TargetData (possibly just a &#39;confirm&#39;)</summary>
	public bool ShouldProduceTargetDataOnServer;
	///<summary>Describes where the targeting action starts, usually the player character or a socket on the player character. //UPROPERTY(BlueprintReadOnly, meta=(ExposeOnSpawn=true), Category=Targeting)</summary>
	public FGameplayAbilityTargetingLocationInfo StartLocation;
	///<summary>Outside code is saying &#39;stop and just give me what you have.&#39; Returns true if the ability accepts this and can be forgotten.</summary>
	public  void ConfirmTargeting() {}
	///<summary>Outside code is saying &#39;stop everything and just forget about it&#39;</summary>
	public  void CancelTargeting() {}
	///<summary>PrimaryPC</summary>
	public APlayerController PrimaryPC;
	///<summary>OwningAbility</summary>
	public UGameplayAbility OwningAbility;
	///<summary>bDestroyOnConfirmation</summary>
	public bool bDestroyOnConfirmation;
	///<summary>SourceActor</summary>
	public AActor SourceActor;
	///<summary>Parameters for world reticle. Usage of these parameters is dependent on the reticle.</summary>
	public FWorldReticleParameters ReticleParams;
	///<summary>Reticle that will appear on top of acquired targets. Reticles will be spawned/despawned as targets are acquired/lost.</summary>
	public UClass ReticleClass;
	///<summary>Using a special class for replication purposes.</summary>
	public FGameplayTargetDataFilterHandle Filter;
	///<summary>Draw the debug information (if applicable) for this targeting actor.</summary>
	public bool bDebug;
	///<summary>GenericDelegateBoundASC</summary>
	public UAbilitySystemComponent GenericDelegateBoundASC;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionExtrasFlyingPawn.h")]
///<summary>Example subclass of ANetworkPredictionExtrasFlyingPawn that uses the MockAbility simulation</summary>
public partial class ANetworkPredictionExtrasFlyingPawn_MockAbility : ANetworkPredictionExtrasFlyingPawn {
// NetworkPredictionExtrasFlyingPawn_MockAbility
	public  UMockFlyingAbilityComponent GetMockFlyingAbilityComponent() { return default; }
	public ENetworkPredictionExtrasMockAbilityInputPreset AbilityInputPreset;
	public  float GetStamina() { return default; }
	public  float GetMaxStamina() { return default; }
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example subclass of ANetworkPredictionExtrasFlyingPawn that uses the MockAbility simulation</summary>
[CppInclude("NetworkPredictionExtrasFlyingPawn.h")]
public partial class ANetworkPredictionExtrasFlyingPawn_MockAbility : ANetworkPredictionExtrasFlyingPawn {
	///<summary>GetMockFlyingAbilityComponent</summary>
	public  UMockFlyingAbilityComponent GetMockFlyingAbilityComponent() { return default; }
	///<summary>AbilityInputPreset</summary>
	public ENetworkPredictionExtrasMockAbilityInputPreset AbilityInputPreset;
	///<summary>GetStamina</summary>
	public  float GetStamina() { return default; }
	///<summary>GetMaxStamina</summary>
	public  float GetMaxStamina() { return default; }
}

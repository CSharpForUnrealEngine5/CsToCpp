#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionExtrasCharacter.h")]
///<summary>Example subclass of ANetworkPredictionExtrasCharacter that uses the MockAbility simulation</summary>
public partial class ANetworkPredictionExtrasCharacter_MockAbility : ANetworkPredictionExtrasCharacter {
// NetworkPredictionExtrasCharacter_MockAbility
	public  UMockCharacterAbilityComponent GetMockCharacterAbilityComponent() { return default; }
	public ENetworkPredictionExtrasMockCharacterAbilityInputPreset AbilityInputPreset;
	public  float GetStamina() { return default; }
	public  float GetMaxStamina() { return default; }
}

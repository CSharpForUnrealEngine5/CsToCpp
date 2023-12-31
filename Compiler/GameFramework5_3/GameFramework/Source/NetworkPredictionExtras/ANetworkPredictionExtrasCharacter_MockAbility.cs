namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Example subclass of ANetworkPredictionExtrasCharacter that uses the MockAbility simulation</summary>
[CppInclude("NetworkPredictionExtrasCharacter.h")]
public partial class ANetworkPredictionExtrasCharacter_MockAbility : ANetworkPredictionExtrasCharacter {
	public static UClass StaticClass() {return default;}
	///<summary>GetMockCharacterAbilityComponent</summary>
	public UMockCharacterAbilityComponent GetMockCharacterAbilityComponent() { return default; }
	///<summary>AbilityInputPreset</summary>
	public ENetworkPredictionExtrasMockCharacterAbilityInputPreset AbilityInputPreset;
	///<summary>GetStamina</summary>
	public float GetStamina() { return default; }
	///<summary>GetMaxStamina</summary>
	public float GetMaxStamina() { return default; }
}

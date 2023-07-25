#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetworkPredictionExtrasCharacter.h")]
///<summary>Sample pawn that uses UCharacterMotionComponent. The main thing this provides is actually producing user input for the component/simulation to consume.</summary>
public partial class ANetworkPredictionExtrasCharacter : APawn {
// NetworkPredictionExtrasCharacter
	public ENetworkPredictionExtrasCharacterInputPreset InputPreset;
	public bool bFakeAutonomousProxy;
	public void PrintDebug() {}
	public float GetMaxMoveSpeed() { return default; }
	public void SetMaxMoveSpeed(float NewMaxMoveSpeed) {}
	public void AddMaxMoveSpeed(float AdditiveMaxMoveSpeed) {}
	public UCharacterMotionComponent CharacterMotionComponent;
}

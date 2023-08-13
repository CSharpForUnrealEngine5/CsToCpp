namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sample pawn that uses UCharacterMotionComponent. The main thing this provides is actually producing user input for the component/simulation to consume.</summary>
[CppInclude("NetworkPredictionExtrasCharacter.h")]
public partial class ANetworkPredictionExtrasCharacter : APawn {
	public static UClass StaticClass() {return default;}
	///<summary>For bFakeAutonomousProxy only</summary>
	public ENetworkPredictionExtrasCharacterInputPreset InputPreset;
	///<summary>Actor will behave like autonomous proxy even though not posessed by an APlayercontroller. To be used in conjuction with InputPreset.</summary>
	public bool bFakeAutonomousProxy;
	///<summary>PrintDebug</summary>
	public void PrintDebug() {}
	///<summary>GetMaxMoveSpeed</summary>
	public float GetMaxMoveSpeed() { return default; }
	///<summary>SetMaxMoveSpeed</summary>
	public void SetMaxMoveSpeed(float NewMaxMoveSpeed) {}
	///<summary>AddMaxMoveSpeed</summary>
	public void AddMaxMoveSpeed(float AdditiveMaxMoveSpeed) {}
	///<summary>CharacterMotionComponent</summary>
	public UCharacterMotionComponent CharacterMotionComponent;
}

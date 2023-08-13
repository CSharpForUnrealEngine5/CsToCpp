namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about a predicted future location</summary>
[CppInclude("GameplayActuationState.h")]
public partial struct FGameplayActuationPredictedLocation {
	public FVector Location;
	public FVector3f Direction;
	public float Time;
	public float Speed;
}

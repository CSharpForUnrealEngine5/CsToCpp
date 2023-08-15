namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for all actuation states</summary>
[CppInclude("GameplayActuationState.h")]
public partial struct FGameplayActuationStateBase {
	public FName ActuationName;
	public FVector NavigationLocation;
}

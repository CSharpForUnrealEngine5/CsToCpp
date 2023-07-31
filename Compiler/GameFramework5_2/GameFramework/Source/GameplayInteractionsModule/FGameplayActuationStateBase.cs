#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct for all actuation states</summary>
[CppInclude("GameplayActuationState.h")]
public partial struct FGameplayActuationStateBase {
	public string ActuationName;
	public FVector NavigationLocation;
}

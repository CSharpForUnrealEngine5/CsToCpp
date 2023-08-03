#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for building triggers.</summary>
[CppInclude("InputTriggers.h")]
public partial class UInputTrigger : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Point at which this trigger fires</summary>
	public float ActuationThreshold;
	///<summary>Decides whether this trigger ticks every frame or not.</summary>
	public bool bShouldAlwaysTick;
	///<summary>* Is the value passed in sufficiently large to be of interest to the trigger.</summary>
	public  bool IsActuated(FInputActionValue ForValue) { return default; }
	///<summary>Value passed to UpdateState on the previous tick. This will be updated automatically after the trigger is updated.</summary>
	public FInputActionValue LastValue;
	///<summary>Changes the way this trigger affects an action with multiple triggers:</summary>
	public  ETriggerType GetTriggerType() { return default; }
	///<summary>This function checks if the requisite conditions have been met for the trigger to fire.</summary>
	public  ETriggerState UpdateState(UEnhancedPlayerInput PlayerInput,FInputActionValue ModifiedValue,float DeltaTime) { return default; }
}

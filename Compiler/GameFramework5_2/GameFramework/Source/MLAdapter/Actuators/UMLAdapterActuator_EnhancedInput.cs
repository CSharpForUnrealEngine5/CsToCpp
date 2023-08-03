#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an agent to simulate player input via the UEnhancedPlayerInput subsystem.</summary>
[CppInclude("Actuators/MLAdapterActuator_EnhancedInput.h")]
public partial class UMLAdapterActuator_EnhancedInput : UMLAdapterActuator {
	public static UClass StaticClass() {return default;}
	///<summary>The actions that this actuator is allowed to inject data into. Modifying this list after using the actuator</summary>
	public TArray<UInputAction> TrackedActions;
	///<summary>bClearActionOnUse</summary>
	public bool bClearActionOnUse;
}

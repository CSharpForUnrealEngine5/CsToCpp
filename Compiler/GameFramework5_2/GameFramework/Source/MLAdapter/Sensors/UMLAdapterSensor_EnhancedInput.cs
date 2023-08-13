namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sensors/MLAdapterSensor_EnhancedInput.h")]
public partial class UMLAdapterSensor_EnhancedInput : UMLAdapterSensor {
	public static UClass StaticClass() {return default;}
	///<summary>TrackedActions</summary>
	public TArray<UInputAction> TrackedActions;
	///<summary>InputComponent</summary>
	public UEnhancedInputComponent InputComponent;
	///<summary>OnInputAction</summary>
	public void OnInputAction(FInputActionInstance ActionInstance) {}
}

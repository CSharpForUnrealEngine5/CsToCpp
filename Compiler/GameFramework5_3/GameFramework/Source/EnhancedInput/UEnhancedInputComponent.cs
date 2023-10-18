namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implement an Actor component for input bindings.</summary>
[CppInclude("EnhancedInputComponent.h")]
public partial class UEnhancedInputComponent : UInputComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Helper function to pull the action value for a bound action value.</summary>
	public FInputActionValue GetBoundActionValue(UInputAction Action) { return default; }
}

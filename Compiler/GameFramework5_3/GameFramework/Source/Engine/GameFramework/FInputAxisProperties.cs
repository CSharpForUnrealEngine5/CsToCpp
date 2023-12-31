namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configurable properties for control axes, used to transform raw input into game ready values.</summary>
[CppInclude("GameFramework/PlayerInput.h")]
public partial struct FInputAxisProperties {
	public float DeadZone;
	public float Sensitivity;
	public float Exponent;
	public bool bInvert;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerInput.h")]
///<summary>Configurable properties for control axes, used to transform raw input into game ready values.</summary>
public partial struct FInputAxisProperties {
// InputAxisProperties
	public float DeadZone;
	public float Sensitivity;
	public float Exponent;
	public bool bInvert;
}

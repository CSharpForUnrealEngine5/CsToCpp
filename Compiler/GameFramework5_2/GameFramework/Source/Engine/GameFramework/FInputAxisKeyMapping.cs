#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a mapping between an axis and key</summary>
[CppInclude("GameFramework/PlayerInput.h")]
public partial struct FInputAxisKeyMapping {
	public string AxisName;
	public float Scale;
	public FKey Key;
}

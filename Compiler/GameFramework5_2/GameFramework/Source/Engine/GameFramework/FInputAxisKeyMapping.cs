#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PlayerInput.h")]
///<summary>Defines a mapping between an axis and key</summary>
public partial struct FInputAxisKeyMapping {
// InputAxisKeyMapping
	public string AxisName;
	public float Scale;
	public FKey Key;
}

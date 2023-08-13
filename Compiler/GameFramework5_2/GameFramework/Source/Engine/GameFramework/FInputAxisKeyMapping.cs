namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a mapping between an axis and key</summary>
[CppInclude("GameFramework/PlayerInput.h")]
public partial struct FInputAxisKeyMapping {
	public string AxisName;
	public float Scale;
	public FKey Key;
}

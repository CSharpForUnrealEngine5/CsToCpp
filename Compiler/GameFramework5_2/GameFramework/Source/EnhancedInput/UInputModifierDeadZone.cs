#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputModifiers.h")]
///<summary>Dead Zone</summary>
public partial class UInputModifierDeadZone : UInputModifier {
// InputModifierDeadZone
	public float LowerThreshold;
	public float UpperThreshold;
	public EDeadZoneType Type;
}

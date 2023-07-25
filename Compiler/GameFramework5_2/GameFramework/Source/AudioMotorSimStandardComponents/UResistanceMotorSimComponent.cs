#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ResistanceMotorSimComponent.h")]
///<summary>Applys additional surface friction based on the angle of the vehicle's velocity</summary>
public partial class UResistanceMotorSimComponent : UAudioMotorSimComponent {
// ResistanceMotorSimComponent
	public float UpSpeedMaxFriction;
	public float MinSpeed;
	public FRuntimeFloatCurve SideSpeedFrictionCurve;
}

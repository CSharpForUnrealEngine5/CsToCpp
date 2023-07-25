#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RpmCurveMotorSimComponent.h")]
///<summary>Derives Gear and RPM directly from speed using hand drawn curves and gear thresholds</summary>
public partial class URpmCurveMotorSimComponent : UAudioMotorSimComponent {
// RpmCurveMotorSimComponent
	public TArray<FMotorSimGearCurve> Gears;
	public float InterpSpeed;
	public FOnGearChangedEvent OnUpShift;
	public FOnGearChangedEvent OnDownShift;
}

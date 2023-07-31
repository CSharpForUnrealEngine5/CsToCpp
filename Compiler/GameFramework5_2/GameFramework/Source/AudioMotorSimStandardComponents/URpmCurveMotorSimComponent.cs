#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Derives Gear and RPM directly from speed using hand drawn curves and gear thresholds</summary>
[CppInclude("RpmCurveMotorSimComponent.h")]
public partial class URpmCurveMotorSimComponent : UAudioMotorSimComponent {
	///<summary>Gears</summary>
	public TArray<FMotorSimGearCurve> Gears;
	///<summary>InterpSpeed</summary>
	public float InterpSpeed;
	///<summary>OnUpShift</summary>
	public FOnGearChangedEvent OnUpShift;
	///<summary>OnDownShift</summary>
	public FOnGearChangedEvent OnDownShift;
}

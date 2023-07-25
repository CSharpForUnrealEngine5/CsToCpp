#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassMovementTypes.h")]
///<summary>Movement style parameters. A movement style abstracts movement properties for specific style. Behaviors can refer to specific styles when handling speeds.</summary>
public partial struct FMassMovementStyleParameters {
// MassMovementStyleParameters
	public FMassMovementStyleRef Style;
	public TArray<FMassMovementStyleSpeedParameters> DesiredSpeeds;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movement style parameters. A movement style abstracts movement properties for specific style. Behaviors can refer to specific styles when handling speeds.</summary>
[CppInclude("MassMovementTypes.h")]
public partial struct FMassMovementStyleParameters {
	public FMassMovementStyleRef Style;
	public TArray<FMassMovementStyleSpeedParameters> DesiredSpeeds;
}

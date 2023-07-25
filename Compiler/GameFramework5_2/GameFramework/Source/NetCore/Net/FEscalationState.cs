#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Net/Core/Connection/EscalationStates.h")]
///<summary>Base struct which defines an escalation state, which is subclassed to implement custom state variables and (de-)escalation quota's.</summary>
public partial struct FEscalationState {
// EscalationState
	public bool bLogEscalate;
	public bool bDormant;
	public short CooloffTime;
	public short AutoEscalateTime;
	public short HighestTimePeriod;
	public TArray<short> AllTimePeriods;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base struct which defines an escalation state, which is subclassed to implement custom state variables and (de-)escalation quota&#39;s.</summary>
[CppInclude("Net/Core/Connection/EscalationStates.h")]
public partial struct FEscalationState {
	public bool bLogEscalate;
	public bool bDormant;
	public short CooloffTime;
	public short AutoEscalateTime;
	public short HighestTimePeriod;
	public TArray<short> AllTimePeriods;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for defining escalation state configuration.</summary>
[CppInclude("Net/Core/Connection/EscalationStates.h")]
public partial class UEscalationManagerConfig : UStatePerObjectConfig {
	///<summary>Names of the different states for escalating severity, depending on conditions for each state</summary>
	public TArray<string> EscalationSeverity;
}

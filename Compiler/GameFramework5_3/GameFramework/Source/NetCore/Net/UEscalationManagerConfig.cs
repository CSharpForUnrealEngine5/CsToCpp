namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for defining escalation state configuration.</summary>
[CppInclude("Net/Core/Connection/EscalationStates.h")]
public partial class UEscalationManagerConfig : UStatePerObjectConfig {
	public static UClass StaticClass() {return default;}
	///<summary>Names of the different states for escalating severity, depending on conditions for each state</summary>
	public TArray<string> EscalationSeverity;
}

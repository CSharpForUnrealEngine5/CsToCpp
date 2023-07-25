#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sensors/MLAdapterSensor.h")]
///<summary>Allows an agent to sense information about the game world or itself.</summary>
public partial class UMLAdapterSensor : UMLAdapterAgentElement {
// MLAdapterSensor
	public bool bRequiresPawn;
	public bool bIsPolling;
	public EMLAdapterTickPolicy TickPolicy;
}

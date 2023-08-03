#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an agent to sense information about the game world or itself.</summary>
[CppInclude("Sensors/MLAdapterSensor.h")]
public partial class UMLAdapterSensor : UMLAdapterAgentElement {
	public static UClass StaticClass() {return default;}
	///<summary>@todo this is not currently referenced anywhere</summary>
	public bool bRequiresPawn;
	///<summary>@todo this is not currently referenced anywhere</summary>
	public bool bIsPolling;
	///<summary>Determines what frequency this sensor ticks at.</summary>
	public EMLAdapterTickPolicy TickPolicy;
}

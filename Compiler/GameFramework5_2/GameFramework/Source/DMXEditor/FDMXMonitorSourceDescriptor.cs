#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXEditorSettings.h")]
///<summary>Struct to describe a monitor source, so it can be stored in settings</summary>
public partial struct FDMXMonitorSourceDescriptor {
// DMXMonitorSourceDescriptor
	public bool bMonitorAllPorts;
	public bool bMonitorInputPorts;
	public FGuid MonitoredPortGuid;
}

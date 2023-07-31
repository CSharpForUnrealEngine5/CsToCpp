#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to describe a monitor source, so it can be stored in settings</summary>
[CppInclude("DMXEditorSettings.h")]
public partial struct FDMXMonitorSourceDescriptor {
	public bool bMonitorAllPorts;
	public bool bMonitorInputPorts;
	public FGuid MonitoredPortGuid;
}

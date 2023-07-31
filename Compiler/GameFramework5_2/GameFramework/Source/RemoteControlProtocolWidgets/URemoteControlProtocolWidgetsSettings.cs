#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remote Control Protocol Widget Settings</summary>
[CppInclude("RemoteControlProtocolWidgetsSettings.h")]
public partial class URemoteControlProtocolWidgetsSettings : UObject {
	///<summary>Protocol types to be hidden in the list view.</summary>
	public TSet<string> HiddenProtocolTypeNames;
	///<summary>Last protocol added. Used as default in the binding list.</summary>
	public string PreferredProtocol;
}

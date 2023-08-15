namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Remote Control Protocol Widget Settings</summary>
[CppInclude("RemoteControlProtocolWidgetsSettings.h")]
public partial class URemoteControlProtocolWidgetsSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Protocol types to be hidden in the list view.</summary>
	public TSet<FName> HiddenProtocolTypeNames;
	///<summary>Last protocol added. Used as default in the binding list.</summary>
	public FName PreferredProtocol;
}

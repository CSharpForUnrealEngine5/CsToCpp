#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The DMX Control Console</summary>
[CppInclude("DMXControlConsoleData.h")]
public partial class UDMXControlConsoleData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Library used to generate Fader Groups</summary>
	public TWeakObjectPtr<UDMXLibrary> DMXLibrary;
	///<summary>DMX Control Console&#39;s Fader Group Rows array</summary>
	public TArray<UDMXControlConsoleFaderGroupRow> FaderGroupRows;
}

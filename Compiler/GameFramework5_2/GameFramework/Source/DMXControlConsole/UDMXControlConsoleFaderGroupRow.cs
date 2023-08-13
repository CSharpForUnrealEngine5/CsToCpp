namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A Row of Fader Groups in the DMX Control Console</summary>
[CppInclude("DMXControlConsoleFaderGroupRow.h")]
public partial class UDMXControlConsoleFaderGroupRow : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Fader Groups array of this Fader Group Row</summary>
	public TArray<UDMXControlConsoleFaderGroup> FaderGroups;
}

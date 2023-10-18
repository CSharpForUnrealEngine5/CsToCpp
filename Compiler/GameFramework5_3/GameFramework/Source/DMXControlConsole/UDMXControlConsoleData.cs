namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The DMX Control Console</summary>
[CppInclude("DMXControlConsoleData.h")]
public partial class UDMXControlConsoleData : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The current editor filter string</summary>
	public string FilterString;
	///<summary>Library used to generate Fader Groups</summary>
	public TSoftObjectPtr<UDMXLibrary> SoftDMXLibraryPtr;
	///<summary>Cached DMX Library for faster access</summary>
	public TWeakObjectPtr<UDMXLibrary> CachedWeakDMXLibrary;
	///<summary>DMX Control Console&#39;s Fader Group Rows array</summary>
	public TArray<UDMXControlConsoleFaderGroupRow> FaderGroupRows;
}

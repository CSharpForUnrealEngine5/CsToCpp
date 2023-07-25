#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXControlConsoleData.h")]
///<summary>The DMX Control Console</summary>
public partial class UDMXControlConsoleData : UObject {
// DMXControlConsoleData
	public TWeakObjectPtr<UDMXLibrary> DMXLibrary;
	public TArray<UDMXControlConsoleFaderGroupRow> FaderGroupRows;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXControlConsoleFixturePatchMatrixCell.h")]
///<summary>A fader matching a Fixture Patch Matrix Cell in the DMX Control Console.</summary>
public partial class UDMXControlConsoleFixturePatchMatrixCell : UObject {
// DMXControlConsoleFixturePatchMatrixCell
	public int CellID;
	public int CellX;
	public int CellY;
	public TArray<UDMXControlConsoleFaderBase> CellAttributeFaders;
}

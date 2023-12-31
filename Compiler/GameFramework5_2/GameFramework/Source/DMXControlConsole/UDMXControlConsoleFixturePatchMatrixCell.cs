namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A fader matching a Fixture Patch Matrix Cell in the DMX Control Console.</summary>
[CppInclude("DMXControlConsoleFixturePatchMatrixCell.h")]
public partial class UDMXControlConsoleFixturePatchMatrixCell : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Cell Index ID</summary>
	public int CellID;
	///<summary>Cell X coordinate</summary>
	public int CellX;
	///<summary>Cell Y coordinate</summary>
	public int CellY;
	///<summary>Faders array of this Fader Group</summary>
	public TArray<UDMXControlConsoleFaderBase> CellAttributeFaders;
}

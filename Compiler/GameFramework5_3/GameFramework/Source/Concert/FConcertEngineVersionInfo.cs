namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds engine version information</summary>
[CppInclude("ConcertVersion.h")]
public partial struct FConcertEngineVersionInfo {
	public ushort Major;
	public ushort Minor;
	public ushort Patch;
	public uint Changelist;
}

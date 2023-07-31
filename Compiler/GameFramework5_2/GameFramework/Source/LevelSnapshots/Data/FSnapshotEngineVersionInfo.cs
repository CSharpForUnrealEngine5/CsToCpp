#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds engine version information</summary>
[CppInclude("Data/SnapshotVersion.h")]
public partial struct FSnapshotEngineVersionInfo {
	public ushort Major;
	public ushort Minor;
	public ushort Patch;
	public uint Changelist;
}

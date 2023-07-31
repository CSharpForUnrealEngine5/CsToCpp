#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Mirror Table containing all data required by the animation mirroring system.</summary>
[CppInclude("Animation/MirrorDataTable.h")]
public partial struct FMirrorTableRow {
	public string Name;
	public string MirroredName;
	public EMirrorRowType MirrorEntryType;
}

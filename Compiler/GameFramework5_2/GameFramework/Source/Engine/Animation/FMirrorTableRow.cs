namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Mirror Table containing all data required by the animation mirroring system.</summary>
[CppInclude("Animation/MirrorDataTable.h")]
public partial struct FMirrorTableRow {
	public FName Name;
	public FName MirroredName;
	public EMirrorRowType MirrorEntryType;
}

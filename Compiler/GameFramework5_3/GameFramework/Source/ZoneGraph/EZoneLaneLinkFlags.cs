namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>Flags describing the details of a linked adjacent lane.</summary>
public enum EZoneLaneLinkFlags {
	None=0,
	All=-1,
	Left=-1,
	Right=-1,
	Splitting=-1,
	Merging=-1,
	OppositeDirection=-1,
}

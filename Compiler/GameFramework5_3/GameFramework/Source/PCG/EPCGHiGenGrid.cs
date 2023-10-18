namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGCommon.h")]
///<summary>Describes one or more target execution grids.</summary>
public enum EPCGHiGenGrid {
	Uninitialized=0,
	Grid32=32,
	Grid64=64,
	Grid128=128,
	Grid256=256,
	Grid512=512,
	Grid1024=1024,
	Grid2048=2048,
	GridMin=-1,
	GridMax=-1,
	Unbounded=-1,
	GenerationDefault=-1,
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TexAligner/TexAligner.h")]
///<summary>Alignment types.</summary>
public enum ETexAlign {
	TEXALIGN_None=0,
	TEXALIGN_Default=1,
	TEXALIGN_Box=2,
	TEXALIGN_Planar=3,
	TEXALIGN_Fit=4,
	TEXALIGN_PlanarAuto=5,
	TEXALIGN_PlanarWall=6,
	TEXALIGN_PlanarFloor=7,
	TEXALIGN_MAX=8,
}

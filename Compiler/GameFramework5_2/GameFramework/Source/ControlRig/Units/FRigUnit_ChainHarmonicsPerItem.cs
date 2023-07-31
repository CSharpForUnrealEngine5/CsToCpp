#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given a root will drive all items underneath in a chain based harmonics spectrum</summary>
[CppInclude("Units/Highlevel/Harmonics/RigUnit_ChainHarmonics.h")]
public partial struct FRigUnit_ChainHarmonicsPerItem {
	public FRigElementKey ChainRoot;
	public FVector Speed;
	public FRigUnit_ChainHarmonics_Reach Reach;
	public FRigUnit_ChainHarmonics_Wave Wave;
	public FRuntimeFloatCurve WaveCurve;
	public FRigUnit_ChainHarmonics_Pendulum Pendulum;
	public bool bDrawDebug;
	public FTransform DrawWorldOffset;
	public FRigUnit_ChainHarmonics_WorkData WorkData;
}

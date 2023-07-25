#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PainCausingVolume.h")]
///<summary>Volume that causes damage over time to any Actor that overlaps its collision.</summary>
public partial class APainCausingVolume : APhysicsVolume {
// PainCausingVolume
	public bool bPainCausing;
	public float DamagePerSec;
	public UClass DamageType;
	public float PainInterval;
	public bool bEntryPain;
	public bool BACKUP_bPainCausing;
	public AController DamageInstigator;
}

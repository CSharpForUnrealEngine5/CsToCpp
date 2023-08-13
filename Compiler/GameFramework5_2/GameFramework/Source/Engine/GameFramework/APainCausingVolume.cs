namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Volume that causes damage over time to any Actor that overlaps its collision.</summary>
[CppInclude("GameFramework/PainCausingVolume.h")]
public partial class APainCausingVolume : APhysicsVolume {
	public static UClass StaticClass() {return default;}
	///<summary>Whether volume currently causes damage.</summary>
	public bool bPainCausing;
	///<summary>Damage done per second to actors in this volume when bPainCausing=true</summary>
	public float DamagePerSec;
	///<summary>Type of damage done</summary>
	public UClass DamageType;
	///<summary>If pain causing, time between damage applications.</summary>
	public float PainInterval;
	///<summary>if bPainCausing, cause pain when something enters the volume in addition to damage each second</summary>
	public bool bEntryPain;
	///<summary>Checkpointed bPainCausing value</summary>
	public bool BACKUP_bPainCausing;
	///<summary>Controller that gets credit for any damage caused by this volume</summary>
	public AController DamageInstigator;
}

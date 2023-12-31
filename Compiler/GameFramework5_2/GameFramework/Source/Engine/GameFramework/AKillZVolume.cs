namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>KillZVolume is a volume used to determine when actors should be killed. Killing logic is overridden in FellOutOfWorld</summary>
[CppInclude("GameFramework/KillZVolume.h")]
public partial class AKillZVolume : APhysicsVolume {
	public static UClass StaticClass() {return default;}
}

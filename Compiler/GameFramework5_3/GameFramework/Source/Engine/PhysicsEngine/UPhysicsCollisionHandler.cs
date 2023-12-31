namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/PhysicsCollisionHandler.h")]
public partial class UPhysicsCollisionHandler : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>How hard an impact must be to trigger effect/sound</summary>
	public float ImpactThreshold;
	///<summary>Min time between effect/sound being triggered</summary>
	public float ImpactReFireDelay;
	///<summary>Sound to play</summary>
	public USoundBase DefaultImpactSound;
	///<summary>Time since last impact sound</summary>
	public float LastImpactSoundTime;
}

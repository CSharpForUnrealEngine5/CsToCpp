namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MockPhysicsGrenade.h")]
public partial class UMockPhysicsGrenadeComponent : UNetworkPredictionPhysicsComponent {
	public static UClass StaticClass() {return default;}
	///<summary>FMockGrenadeOnExplode</summary>
	public void FMockGrenadeOnExplode() {}
	///<summary>OnExplode</summary>
	public FMockGrenadeOnExplode OnExplode;
	///<summary>FuseTimeSeconds</summary>
	public float FuseTimeSeconds;
	///<summary>Radius</summary>
	public float Radius;
	///<summary>Magnitude</summary>
	public float Magnitude;
}

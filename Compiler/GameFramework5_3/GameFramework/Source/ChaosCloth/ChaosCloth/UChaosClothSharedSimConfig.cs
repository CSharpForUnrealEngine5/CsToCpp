namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Chaos config settings shared between all instances of a skeletal mesh.</summary>
[CppInclude("ChaosCloth/ChaosClothConfig.h")]
public partial class UChaosClothSharedSimConfig : UClothSharedConfigCommon {
	public static UClass StaticClass() {return default;}
	///<summary>The number of time step dependent solver iterations. This sets iterations at 60fps.</summary>
	public int IterationCount;
	///<summary>The maximum number of solver iterations.</summary>
	public int MaxIterationCount;
	///<summary>The number of solver substeps.</summary>
	public int SubdivisionCount;
	///<summary>The radius of the spheres used in self collision</summary>
	public float SelfCollisionThickness_DEPRECATED;
	///<summary>The radius of cloth points when considering collisions against collider shapes.</summary>
	public float CollisionThickness_DEPRECATED;
	///<summary>Use shared config damping rather than per cloth damping.</summary>
	public bool bUseDampingOverride_DEPRECATED;
	///<summary>The amount of cloth damping. Override the per cloth damping coefficients.</summary>
	public float Damping_DEPRECATED;
	///<summary>Use the config gravity value instead of world gravity.</summary>
	public bool bUseGravityOverride_DEPRECATED;
	///<summary>Scale factor applied to the world gravity and also to the clothing simulation interactor gravity. Does not affect the gravity if set using the override below.</summary>
	public float GravityScale_DEPRECATED;
	///<summary>The gravitational acceleration vector [cm/s^2]</summary>
	public FVector Gravity_DEPRECATED;
	///<summary>Enable local space simulation to help with jitter due to floating point precision errors if the character is far away from the world origin</summary>
	public bool bUseLocalSpaceSimulation;
	///<summary>Enable the XPBD constraints that resolve stiffness independently from the number of iterations</summary>
	public bool bUseXPBDConstraints;
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds initial, asset level config for clothing actors. // Hiding categories that will be used in the future</summary>
[CppInclude("ChaosCloth/ChaosClothConfig.h")]
public partial class UChaosClothConfig : UClothConfigCommon {
	public static UClass StaticClass() {return default;}
	///<summary>How cloth particle mass is determined</summary>
	public EClothMassMode MassMode;
	///<summary>The value used when the Mass Mode is set to Uniform Mass.</summary>
	public float UniformMass;
	///<summary>The value used when Mass Mode is set to TotalMass.</summary>
	public float TotalMass;
	///<summary>The value used when Mass Mode is set to Density.</summary>
	public float Density;
	///<summary>This is a lower bound to cloth particle masses.</summary>
	public float MinPerParticleMass;
	///<summary>The Stiffness of segments constraints. Increase the iteration count for stiffer materials.</summary>
	public FChaosClothWeightedValue EdgeStiffnessWeighted;
	///<summary>The Stiffness of cross segments and bending elements constraints. Increase the iteration count for stiffer materials.</summary>
	public FChaosClothWeightedValue BendingStiffnessWeighted;
	///<summary>Enable the more accurate bending element constraints instead of the faster cross-edge spring constraints used for controlling bending stiffness.</summary>
	public bool bUseBendingElements;
	///<summary>Once the element has bent such that it&#39;s folded more than this ratio from its rest angle (&quot;buckled&quot;), switch to using Buckling Stiffness instead of Bending Stiffness.</summary>
	public float BucklingRatio;
	///<summary>Bending will use this stiffness instead of Bending Stiffness once the cloth has buckled, i.e., bent beyond a certain angle.</summary>
	public FChaosClothWeightedValue BucklingStiffnessWeighted;
	///<summary>The stiffness of the surface area preservation constraints. Increase the iteration count for stiffer materials.</summary>
	public FChaosClothWeightedValue AreaStiffnessWeighted;
	///<summary>The stiffness of the volume preservation constraints.</summary>
	public float VolumeStiffness;
	///<summary>The tethers&#39; stiffness of the long range attachment constraints.</summary>
	public FChaosClothWeightedValue TetherStiffness;
	///<summary>The limit scale of the long range attachment constraints (aka tether limit).</summary>
	public FChaosClothWeightedValue TetherScale;
	///<summary>Use geodesic instead of euclidean distance calculations for the Long Range Attachment constraint,</summary>
	public bool bUseGeodesicDistance;
	///<summary>The stiffness of the shape target constraints.</summary>
	public float ShapeTargetStiffness;
	///<summary>The added thickness of collision shapes.</summary>
	public float CollisionThickness;
	///<summary>Friction coefficient for cloth - collider interaction.</summary>
	public float FrictionCoefficient;
	///<summary>Use continuous collision detection (CCD) to prevent any missed collisions between fast moving particles and colliders.</summary>
	public bool bUseCCD;
	///<summary>Enable self collision repulsion forces (point-face).</summary>
	public bool bUseSelfCollisions;
	///<summary>The radius of the spheres used in self collision. (i.e., offset per side. total thickness of cloth is 2x this value)</summary>
	public float SelfCollisionThickness;
	///<summary>Friction coefficient for cloth - cloth interaction.</summary>
	public float SelfCollisionFriction;
	///<summary>Enable self intersection resolution. This will try to fix any cloth intersections that are not handled by collision repulsions.</summary>
	public bool bUseSelfIntersections;
	///<summary>This parameter is automatically set by the migration code. It can be overridden here to use the old way of authoring the backstop distances.</summary>
	public bool bUseLegacyBackstop;
	///<summary>The amount of global damping applied to the cloth velocities, also known as point damping.</summary>
	public float DampingCoefficient;
	///<summary>The amount of local damping applied to the cloth velocities.</summary>
	public float LocalDampingCoefficient;
	///<summary>This parameter is automatically set by the migration code. It can be overridden here to use the old deprecated &quot;Legacy&quot; wind model in order to preserve behavior with previous versions of the engine.</summary>
	public bool bUsePointBasedWindModel;
	///<summary>The aerodynamic coefficient of drag applying on each particle.</summary>
	public FChaosClothWeightedValue Drag;
	///<summary>The aerodynamic coefficient of lift applying on each particle.</summary>
	public FChaosClothWeightedValue Lift;
	///<summary>Use the config gravity value instead of world gravity.</summary>
	public bool bUseGravityOverride;
	///<summary>Scale factor applied to the world gravity and also to the clothing simulation interactor gravity. Does not affect the gravity if set using the override below.</summary>
	public float GravityScale;
	///<summary>The gravitational acceleration vector [cm/s^2]</summary>
	public FVector Gravity;
	///<summary>Pressure force strength applied in the normal direction(use negative value to push toward backface)</summary>
	public FChaosClothWeightedValue Pressure;
	///<summary>The strength of the constraint driving the cloth towards the animated goal mesh.</summary>
	public FChaosClothWeightedValue AnimDriveStiffness;
	///<summary>The damping amount of the anim drive.</summary>
	public FChaosClothWeightedValue AnimDriveDamping;
	///<summary>The amount of linear velocities sent to the local cloth space from the reference bone</summary>
	public FVector LinearVelocityScale;
	///<summary>The amount of angular velocities sent to the local cloth space from the reference bone</summary>
	public float AngularVelocityScale;
	///<summary>The portion of the angular velocity that is used to calculate the strength of all fictitious forces (e.g. centrifugal force).</summary>
	public float FictitiousAngularScale;
	///<summary>Enable tetrahedral constraints.</summary>
	public bool bUseTetrahedralConstraints;
	///<summary>Enable thin shell volume constraints.</summary>
	public bool bUseThinShellVolumeConstraints;
	///<summary>Enable continuous collision detection.</summary>
	public bool bUseContinuousCollisionDetection;
	///<summary>EdgeStiffness_DEPRECATED</summary>
	public float EdgeStiffness_DEPRECATED;
	///<summary>The Stiffness of the bending constraints. Increase the iteration count for stiffer materials. Increase the iteration count for stiffer materials.</summary>
	public float BendingStiffness_DEPRECATED;
	///<summary>The stiffness of the area preservation constraints. Increase the iteration count for stiffer materials.</summary>
	public float AreaStiffness_DEPRECATED;
	///<summary>TetherMode_DEPRECATED</summary>
	public EChaosClothTetherMode TetherMode_DEPRECATED;
	///<summary>LimitScale_DEPRECATED</summary>
	public float LimitScale_DEPRECATED;
	///<summary>DragCoefficient_DEPRECATED</summary>
	public float DragCoefficient_DEPRECATED;
	///<summary>LiftCoefficient_DEPRECATED</summary>
	public float LiftCoefficient_DEPRECATED;
	///<summary>AnimDriveSpringStiffness_DEPRECATED</summary>
	public float AnimDriveSpringStiffness_DEPRECATED;
	///<summary>StrainLimitingStiffness_DEPRECATED</summary>
	public float StrainLimitingStiffness_DEPRECATED;
}

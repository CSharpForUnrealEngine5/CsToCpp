#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothConfigNv.h")]
public partial class UClothConfigNv : UClothConfigCommon {
	///<summary>How wind should be processed, Accurate uses drag and lift to make the cloth react differently, legacy applies similar forces to all clothing without drag and lift (similar to APEX)</summary>
	public EClothingWindMethodNv ClothingWindMethod;
	///<summary>Constraint data for vertical constraints</summary>
	public FClothConstraintSetupNv VerticalConstraint;
	///<summary>Constraint data for horizontal constraints</summary>
	public FClothConstraintSetupNv HorizontalConstraint;
	///<summary>Constraint data for bend constraints</summary>
	public FClothConstraintSetupNv BendConstraint;
	///<summary>Constraint data for shear constraints</summary>
	public FClothConstraintSetupNv ShearConstraint;
	///<summary>Size of self collision spheres centered on each vert</summary>
	public float SelfCollisionRadius;
	///<summary>Stiffness of the spring force that will resolve self collisions</summary>
	public float SelfCollisionStiffness;
	///<summary>Scale to use for the radius of the culling checks for self collisions.</summary>
	public float SelfCollisionCullScale;
	///<summary>Damping of particle motion per-axis</summary>
	public FVector Damping;
	///<summary>Friction of the surface when colliding</summary>
	public float Friction;
	///<summary>Drag coefficient for wind calculations, higher values mean wind has more lateral effect on cloth</summary>
	public float WindDragCoefficient;
	///<summary>Lift coefficient for wind calculations, higher values make cloth rise easier in wind</summary>
	public float WindLiftCoefficient;
	///<summary>Drag applied to linear particle movement per-axis</summary>
	public FVector LinearDrag;
	///<summary>Drag applied to angular particle movement, higher values should limit material bending (per-axis)</summary>
	public FVector AngularDrag;
	///<summary>Scale for linear particle inertia, how much movement should translate to linear motion (per-axis)</summary>
	public FVector LinearInertiaScale;
	///<summary>Scale for angular particle inertia, how much movement should translate to angular motion (per-axis)</summary>
	public FVector AngularInertiaScale;
	///<summary>Scale for centrifugal particle inertia, how much movement should translate to angular motion (per-axis)</summary>
	public FVector CentrifugalInertiaScale;
	///<summary>Frequency of the position solver, lower values will lead to stretchier, bouncier cloth</summary>
	public float SolverFrequency;
	///<summary>Frequency for stiffness calculations, lower values will degrade stiffness of constraints</summary>
	public float StiffnessFrequency;
	///<summary>Scale of gravity effect on particles</summary>
	public float GravityScale;
	///<summary>Direct gravity override value</summary>
	public FVector GravityOverride;
	///<summary>Use gravity override value vs gravity scale</summary>
	public bool bUseGravityOverride;
	///<summary>Scale for stiffness of particle tethers between each other</summary>
	public float TetherStiffness;
	///<summary>Scale for the limit of particle tethers (how far they can separate)</summary>
	public float TetherLimit;
	///<summary>&#39;Thickness&#39; of the simulated cloth, used to adjust collisions</summary>
	public float CollisionThickness;
	///<summary>Default spring stiffness for anim drive if an anim drive is in use</summary>
	public float AnimDriveSpringStiffness;
	///<summary>Default damper stiffness for anim drive if an anim drive is in use</summary>
	public float AnimDriveDamperStiffness;
	///<summary>Deprecated properties using old legacy structure and enum that couldn&#39;t be redirected</summary>
	public EClothingWindMethod_Legacy WindMethod_DEPRECATED;
	///<summary>VerticalConstraintConfig_DEPRECATED</summary>
	public FClothConstraintSetup_Legacy VerticalConstraintConfig_DEPRECATED;
	///<summary>HorizontalConstraintConfig_DEPRECATED</summary>
	public FClothConstraintSetup_Legacy HorizontalConstraintConfig_DEPRECATED;
	///<summary>BendConstraintConfig_DEPRECATED</summary>
	public FClothConstraintSetup_Legacy BendConstraintConfig_DEPRECATED;
	///<summary>ShearConstraintConfig_DEPRECATED</summary>
	public FClothConstraintSetup_Legacy ShearConstraintConfig_DEPRECATED;
}

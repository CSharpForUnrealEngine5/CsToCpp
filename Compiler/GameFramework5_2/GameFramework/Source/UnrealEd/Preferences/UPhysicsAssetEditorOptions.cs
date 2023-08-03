#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Preferences/PhysicsAssetEditorOptions.h")]
public partial class UPhysicsAssetEditorOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Lets you manually control the physics/animation</summary>
	public float PhysicsBlend;
	///<summary>Lets you manually control the physics/animation</summary>
	public bool bUpdateJointsFromAnimation;
	///<summary>Determines whether simulation of root body updates component transform</summary>
	public EPhysicsTransformUpdateMode PhysicsUpdateMode;
	///<summary>Time between poking ragdoll and starting to blend back.</summary>
	public float PokePauseTime;
	///<summary>Time taken to blend from physics to animation.</summary>
	public float PokeBlendTime;
	///<summary>Scale factor for the gravity used in the simulation</summary>
	public float GravScale;
	///<summary>Gravity override used in the simulation</summary>
	public float GravityOverrideZ;
	///<summary>Toggle gravity override vs gravity scale</summary>
	public bool bUseGravityOverride;
	///<summary>Max FPS for simulation in PhysicsAssetEditor. This is helpful for targeting the same FPS as your game. -1 means disabled</summary>
	public int MaxFPS;
	///<summary>Linear damping of mouse spring forces</summary>
	public float HandleLinearDamping;
	///<summary>Linear stiffness of mouse spring forces</summary>
	public float HandleLinearStiffness;
	///<summary>Angular damping of mouse spring forces</summary>
	public float HandleAngularDamping;
	///<summary>Angular stiffness of mouse spring forces</summary>
	public float HandleAngularStiffness;
	///<summary>How quickly we interpolate the physics target transform for mouse spring forces</summary>
	public float InterpolationSpeed;
	///<summary>Strength of the impulse used when poking with left mouse button</summary>
	public float PokeStrength;
	///<summary>Raycast distance when poking or grabbing</summary>
	public float InteractionDistance;
	///<summary>Whether to draw constraints as points</summary>
	public bool bShowConstraintsAsPoints;
	///<summary>Whether to only render selected constraints</summary>
	public bool bRenderOnlySelectedConstraints;
	///<summary>Toggle collisions with floor in the simulation</summary>
	public bool bSimulationFloorCollisionEnabled;
	///<summary>Controls how large constraints are drawn in Physics Asset Editor</summary>
	public float ConstraintDrawSize;
	///<summary>View mode for meshes in edit mode</summary>
	public EPhysicsAssetEditorMeshViewMode MeshViewMode;
	///<summary>View mode for collision in edit mode</summary>
	public EPhysicsAssetEditorCollisionViewMode CollisionViewMode;
	///<summary>View mode for constraints in edit mode</summary>
	public EPhysicsAssetEditorConstraintViewMode ConstraintViewMode;
	///<summary>View mode for meshes in simulation mode</summary>
	public EPhysicsAssetEditorMeshViewMode SimulationMeshViewMode;
	///<summary>View mode for collision in simulation mode</summary>
	public EPhysicsAssetEditorCollisionViewMode SimulationCollisionViewMode;
	///<summary>View mode for constraints in simulation mode</summary>
	public EPhysicsAssetEditorConstraintViewMode SimulationConstraintViewMode;
	///<summary>Opacity of &#39;solid&#39; rendering</summary>
	public float CollisionOpacity;
	///<summary>When set, turns opacity of solid rendering for unselected bodies to zero</summary>
	public bool bSolidRenderingForSelectedOnly;
	///<summary>When set, disables rendering for simulated bodies</summary>
	public bool bHideSimulatedBodies;
	///<summary>When set, disables rendering for kinematic bodies</summary>
	public bool bHideKinematicBodies;
	///<summary>When set, cloth will reset each time simulation is toggled</summary>
	public bool bResetClothWhenSimulating;
}

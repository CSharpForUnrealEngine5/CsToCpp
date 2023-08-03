#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Physical materials are used to define the response of a physical object when interacting dynamically with the world.</summary>
[CppInclude("PhysicalMaterials/PhysicalMaterial.h")]
public partial class UPhysicalMaterial : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Friction value of surface, controls how easily things can slide on this surface (0 is frictionless, higher values increase the amount of friction)</summary>
	public float Friction;
	///<summary>Static Friction value of surface, controls how easily things can slide on this surface (0 is frictionless, higher values increase the amount of friction)</summary>
	public float StaticFriction;
	///<summary>Friction combine mode, controls how friction is computed for multiple materials.</summary>
	public EFrictionCombineMode FrictionCombineMode;
	///<summary>If set we will use the FrictionCombineMode of this material, instead of the FrictionCombineMode found in the project settings.</summary>
	public bool bOverrideFrictionCombineMode;
	///<summary>Restitution or &#39;bounciness&#39; of this surface, between 0 (no bounce) and 1 (outgoing velocity is same as incoming).</summary>
	public float Restitution;
	///<summary>Restitution combine mode, controls how restitution is computed for multiple materials.</summary>
	public EFrictionCombineMode RestitutionCombineMode;
	///<summary>If set we will use the RestitutionCombineMode of this material, instead of the RestitutionCombineMode found in the project settings.</summary>
	public bool bOverrideRestitutionCombineMode;
	///<summary>Used with the shape of the object to calculate its mass properties. The higher the number, the heavier the object. g per cubic cm.</summary>
	public float Density;
	///<summary>How low the linear velocity can be before solver puts body to sleep.</summary>
	public float SleepLinearVelocityThreshold;
	///<summary>How low the angular velocity can be before solver puts body to sleep.</summary>
	public float SleepAngularVelocityThreshold;
	///<summary>How many ticks we can be under thresholds for before solver puts body to sleep.</summary>
	public int SleepCounterThreshold;
	///<summary>Used to adjust the way that mass increases as objects get larger. This is applied to the mass as calculated based on a &#39;solid&#39; object.</summary>
	public float RaiseMassToPower;
	///<summary>How much to scale the damage threshold by on any destructible we are applied to</summary>
	public float DestructibleDamageThresholdScale;
	///<summary>PhysicalMaterialProperty_DEPRECATED</summary>
	public UDEPRECATED_PhysicalMaterialPropertyBase PhysicalMaterialProperty_DEPRECATED;
	///<summary>To edit surface type for your project, use ProjectSettings/Physics/PhysicalSurface section</summary>
	public EPhysicalSurface SurfaceType;
}

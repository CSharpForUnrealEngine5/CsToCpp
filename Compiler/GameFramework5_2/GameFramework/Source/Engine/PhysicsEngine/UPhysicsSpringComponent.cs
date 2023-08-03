#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note: this component is still work in progress. Uses raycast springs for simple vehicle forces</summary>
[CppInclude("PhysicsEngine/PhysicsSpringComponent.h")]
public partial class UPhysicsSpringComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Specifies how much strength the spring has. The higher the SpringStiffness the more force the spring can push on a body with.</summary>
	public float SpringStiffness;
	///<summary>Specifies how quickly the spring can absorb energy of a body. The higher the damping the less oscillation</summary>
	public float SpringDamping;
	///<summary>Determines how long the spring will be along the X-axis at rest. The spring will apply 0 force on a body when it&#39;s at rest.</summary>
	public float SpringLengthAtRest;
	///<summary>Determines the radius of the spring.</summary>
	public float SpringRadius;
	///<summary>Strength of thrust force applied to the base object.</summary>
	public ECollisionChannel SpringChannel;
	///<summary>If true, the spring will ignore all components in its own actor</summary>
	public bool bIgnoreSelf;
	///<summary>The current compression of the spring. A spring at rest will have SpringCompression 0.</summary>
	public float SpringCompression;
	///<summary>Returns the spring compression as a normalized scalar along spring direction.</summary>
	public  float GetNormalizedCompressionScalar() { return default; }
	///<summary>Returns the spring resting point in world space.</summary>
	public  FVector GetSpringRestingPoint() { return default; }
	///<summary>Returns the spring current end point in world space.</summary>
	public  FVector GetSpringCurrentEndPoint() { return default; }
	///<summary>Returns the spring direction from start to resting point</summary>
	public  FVector GetSpringDirection() { return default; }
}

#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Phonon Source Components can be placed alongside statically positioned Audio Components in order to bake impulse response data</summary>
[CppInclude("PhononSourceComponent.h")]
public partial class UPhononSourceComponent : USceneComponent {
	///<summary>Any Phonon probes that lie within the baking radius will be used to produce baked impulse response data for this source location.</summary>
	public float BakingRadius;
	///<summary>Users must specify a unique identifier for baked data lookup at runtime.</summary>
	public string UniqueIdentifier;
}

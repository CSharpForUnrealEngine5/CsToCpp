#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononSourceComponent.h")]
///<summary>Phonon Source Components can be placed alongside statically positioned Audio Components in order to bake impulse response data</summary>
public partial class UPhononSourceComponent : USceneComponent {
// PhononSourceComponent
	public float BakingRadius;
	public string UniqueIdentifier;
}

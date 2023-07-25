#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Lightmass/PrecomputedVisibilityOverrideVolume.h")]
public partial class APrecomputedVisibilityOverrideVolume : AVolume {
// PrecomputedVisibilityOverrideVolume
	public TArray<AActor> OverrideVisibleActors;
	public TArray<AActor> OverrideInvisibleActors;
	public TArray<string> OverrideInvisibleLevels;
}

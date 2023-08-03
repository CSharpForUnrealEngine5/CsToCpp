#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Lightmass/PrecomputedVisibilityOverrideVolume.h")]
public partial class APrecomputedVisibilityOverrideVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>Array of actors that will always be considered visible by Precomputed Visibility when viewed from inside this volume.</summary>
	public TArray<AActor> OverrideVisibleActors;
	///<summary>Array of actors that will always be considered invisible by Precomputed Visibility when viewed from inside this volume.</summary>
	public TArray<AActor> OverrideInvisibleActors;
	///<summary>Array of level names whose actors will always be considered invisible by Precomputed Visibility when viewed from inside this volume.</summary>
	public TArray<string> OverrideInvisibleLevels;
}

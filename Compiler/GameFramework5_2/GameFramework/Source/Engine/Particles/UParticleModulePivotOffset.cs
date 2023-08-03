#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/Modules/Location/ParticleModulePivotOffset.h")]
public partial class UParticleModulePivotOffset : UParticleModuleLocationBase {
	public static UClass StaticClass() {return default;}
	///<summary>Offset applied in UV space to the particle vertex positions. Defaults to (0.5,0.5) putting the pivot in the centre of the partilce.</summary>
	public FVector2D PivotOffset;
}

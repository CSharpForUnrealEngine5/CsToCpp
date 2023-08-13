namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataAnimTrail.h")]
public partial class UParticleModuleTypeDataAnimTrail : UParticleModuleTypeDataBase {
	public static UClass StaticClass() {return default;}
	///<summary>If true, when the system is deactivated, mark trails as dead.</summary>
	public bool bDeadTrailsOnDeactivate;
	///<summary>If true, recalculate the previous tangent when a new particle is spawned</summary>
	public bool bEnablePreviousTangentRecalculation;
	///<summary>If true, recalculate tangents every frame to allow velocity/acceleration to be applied</summary>
	public bool bTangentRecalculationEveryFrame;
	///<summary>The (estimated) covered distance to tile the 2nd UV set at.</summary>
	public float TilingDistance;
	///<summary>The distance step size for tessellation.</summary>
	public float DistanceTessellationStepSize;
	///<summary>The tangent scalar for tessellation.</summary>
	public float TangentTessellationStepSize;
	///<summary>The width step size for tessellation.</summary>
	public float WidthTessellationStepSize;
}

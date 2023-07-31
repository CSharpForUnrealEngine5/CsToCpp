#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_Cone.h")]
public partial class UEnvQueryGenerator_Cone : UEnvQueryGenerator_ProjectedPoints {
	///<summary>Distance between each point of the same angle</summary>
	public FAIDataProviderFloatValue AlignedPointsDistance;
	///<summary>Maximum degrees of the generated cone</summary>
	public FAIDataProviderFloatValue ConeDegrees;
	///<summary>The step of the angle increase. Angle step must be &gt;=1</summary>
	public FAIDataProviderFloatValue AngleStep;
	///<summary>Generation distance</summary>
	public FAIDataProviderFloatValue Range;
	///<summary>The actor (or actors) that will generate a cone in their facing direction</summary>
	public UClass CenterActor;
	///<summary>Whether to include CenterActors&#39; locations when generating items.</summary>
	public bool bIncludeContextLocation;
}

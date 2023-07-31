#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_Donut.h")]
public partial class UEnvQueryGenerator_Donut : UEnvQueryGenerator_ProjectedPoints {
	///<summary>min distance between point and context</summary>
	public FAIDataProviderFloatValue InnerRadius;
	///<summary>max distance between point and context</summary>
	public FAIDataProviderFloatValue OuterRadius;
	///<summary>number of rings to generate</summary>
	public FAIDataProviderIntValue NumberOfRings;
	///<summary>number of items to generate for each ring</summary>
	public FAIDataProviderIntValue PointsPerRing;
	///<summary>If you generate items on a piece of circle you define direction of Arc cut here</summary>
	public FEnvDirection ArcDirection;
	///<summary>If you generate items on a piece of circle you define angle of Arc cut here</summary>
	public FAIDataProviderFloatValue ArcAngle;
	///<summary>If true, the rings of the wheel will be rotated in a spiral pattern.  If false, they will all be at a zero</summary>
	public bool bUseSpiralPattern;
	///<summary>context</summary>
	public UClass Center;
	///<summary>bDefineArc</summary>
	public bool bDefineArc;
}

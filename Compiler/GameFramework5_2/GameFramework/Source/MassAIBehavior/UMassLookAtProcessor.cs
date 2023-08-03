#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Processor to choose and assign LookAt configurations</summary>
[CppInclude("MassLookAtProcessors.h")]
public partial class UMassLookAtProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>Size of the query to find potential targets</summary>
	public float QueryExtent;
	///<summary>Time an entity must use a random look at.</summary>
	public float Duration;
	///<summary>Variation applied to a random look at duration [Duration-Variation : Duration+Variation]</summary>
	public float DurationVariation;
	///<summary>Height offset that will be added for debug draw of the look at vector. Useful to bring arrow near character&#39;s eyes</summary>
	public float DebugZOffset;
	///<summary>Tolerance in degrees between the forward direction and the look at duration to track an entity</summary>
	public float AngleThresholdInDegrees;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FEnvTraceData {
// EnvTraceData
	public int VersionNum;
	public UClass NavigationFilter;
	public float ProjectDown;
	public float ProjectUp;
	public float ExtentX;
	public float ExtentY;
	public float ExtentZ;
	public float PostProjectionVerticalOffset;
	public byte TraceChannel;
	public byte SerializedChannel;
	public string TraceProfileName;
	public byte TraceShape;
	public byte TraceMode;
	public bool bTraceComplex;
	public bool bOnlyBlockingHits;
	public bool bCanTraceOnNavMesh;
	public bool bCanTraceOnGeometry;
	public bool bCanDisableTrace;
	public bool bCanProjectDown;
}

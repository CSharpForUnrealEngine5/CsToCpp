#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FEnvTraceData {
	public int VersionNum;
	public UClass NavigationFilter;
	public float ProjectDown;
	public float ProjectUp;
	public float ExtentX;
	public float ExtentY;
	public float ExtentZ;
	public float PostProjectionVerticalOffset;
	public ETraceTypeQuery TraceChannel;
	public ECollisionChannel SerializedChannel;
	public string TraceProfileName;
	public EEnvTraceShape TraceShape;
	public EEnvQueryTrace TraceMode;
	public bool bTraceComplex;
	public bool bOnlyBlockingHits;
	public bool bCanTraceOnNavMesh;
	public bool bCanTraceOnGeometry;
	public bool bCanDisableTrace;
	public bool bCanProjectDown;
}

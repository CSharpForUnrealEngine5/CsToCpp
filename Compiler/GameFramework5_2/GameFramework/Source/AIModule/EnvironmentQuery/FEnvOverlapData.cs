#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FEnvOverlapData {
	public float ExtentX;
	public float ExtentY;
	public float ExtentZ;
	public FVector ShapeOffset;
	public ECollisionChannel OverlapChannel;
	public EEnvOverlapShape OverlapShape;
	public bool bOnlyBlockingHits;
	public bool bOverlapComplex;
	public bool bSkipOverlapQuerier;
}

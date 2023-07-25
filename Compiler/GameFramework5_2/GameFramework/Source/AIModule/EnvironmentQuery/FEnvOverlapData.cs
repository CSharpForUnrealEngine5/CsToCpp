#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FEnvOverlapData {
// EnvOverlapData
	public float ExtentX;
	public float ExtentY;
	public float ExtentZ;
	public FVector ShapeOffset;
	public byte OverlapChannel;
	public byte OverlapShape;
	public bool bOnlyBlockingHits;
	public bool bOverlapComplex;
	public bool bSkipOverlapQuerier;
}

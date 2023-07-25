#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FRetargetGlobalSettings {
// RetargetGlobalSettings
	public bool bEnableRoot;
	public bool bEnableFK;
	public bool bEnableIK;
	public bool bWarping;
	public EWarpingDirectionSource DirectionSource;
	public EBasicAxis ForwardDirection;
	public string DirectionChain;
	public float WarpForwards;
	public float SidewaysOffset;
	public float WarpSplay;
}

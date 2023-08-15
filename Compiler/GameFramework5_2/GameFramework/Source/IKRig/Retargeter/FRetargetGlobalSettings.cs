namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Retargeter/IKRetargetSettings.h")]
public partial struct FRetargetGlobalSettings {
	public bool bEnableRoot;
	public bool bEnableFK;
	public bool bEnableIK;
	public bool bWarping;
	public EWarpingDirectionSource DirectionSource;
	public EBasicAxis ForwardDirection;
	public FName DirectionChain;
	public float WarpForwards;
	public float SidewaysOffset;
	public float WarpSplay;
}

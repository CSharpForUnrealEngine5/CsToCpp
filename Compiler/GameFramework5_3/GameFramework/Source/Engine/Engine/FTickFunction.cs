namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract Base class for all tick functions.</summary>
[CppInclude("Engine/EngineBaseTypes.h")]
public partial struct FTickFunction {
	public ETickingGroup TickGroup;
	public ETickingGroup EndTickGroup;
	public bool bTickEvenWhenPaused;
	public bool bCanEverTick;
	public bool bStartWithTickEnabled;
	public bool bAllowTickOnDedicatedServer;
	public float TickInterval;
}

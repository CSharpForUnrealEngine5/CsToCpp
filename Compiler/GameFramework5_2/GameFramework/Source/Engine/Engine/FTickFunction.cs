#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineBaseTypes.h")]
///<summary>Abstract Base class for all tick functions.</summary>
public partial struct FTickFunction {
// TickFunction
	public ETickingGroup TickGroup;
	public ETickingGroup EndTickGroup;
	public bool bTickEvenWhenPaused;
	public bool bCanEverTick;
	public bool bStartWithTickEnabled;
	public bool bAllowTickOnDedicatedServer;
	public float TickInterval;
}

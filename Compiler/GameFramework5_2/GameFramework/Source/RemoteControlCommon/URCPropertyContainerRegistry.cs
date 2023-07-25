#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RCPropertyContainer.h")]
///<summary>A subsystem to provide and cache dynamically created PropertyContainer classes.</summary>
public partial class URCPropertyContainerRegistry : UEngineSubsystem {
// RCPropertyContainerRegistry
	public TMap<FRCPropertyContainerKey,UClass> CachedContainerClasses;
}

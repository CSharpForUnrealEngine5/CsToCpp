#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem to provide and cache dynamically created PropertyContainer classes.</summary>
[CppInclude("RCPropertyContainer.h")]
public partial class URCPropertyContainerRegistry : UEngineSubsystem {
	///<summary>CachedContainerClasses</summary>
	public TMap<FRCPropertyContainerKey,UClass> CachedContainerClasses;
}

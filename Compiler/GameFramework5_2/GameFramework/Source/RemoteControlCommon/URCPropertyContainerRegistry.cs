namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem to provide and cache dynamically created PropertyContainer classes.</summary>
[CppInclude("RCPropertyContainer.h")]
public partial class URCPropertyContainerRegistry : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>CachedContainerClasses</summary>
	public TMap<FRCPropertyContainerKey,UClass> CachedContainerClasses;
}

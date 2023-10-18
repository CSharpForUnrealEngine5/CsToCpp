namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Processor for updating move target on ZoneGraph path.</summary>
[CppInclude("MassZoneGraphNavigationProcessors.h")]
public partial class UMassZoneGraphPathFollowProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>SignalSubsystem</summary>
	public UMassSignalSubsystem SignalSubsystem;
}

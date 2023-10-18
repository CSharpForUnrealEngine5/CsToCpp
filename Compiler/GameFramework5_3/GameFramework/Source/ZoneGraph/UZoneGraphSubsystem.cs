namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphSubsystem.h")]
public partial class UZoneGraphSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>RegisteredZoneGraphData</summary>
	public TArray<FRegisteredZoneGraphData> RegisteredZoneGraphData;
}

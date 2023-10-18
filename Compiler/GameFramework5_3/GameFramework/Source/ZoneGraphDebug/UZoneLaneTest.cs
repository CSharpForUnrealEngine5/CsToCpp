namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class to inherit from to be able to perform custom actions on lane detected by the testing actor.</summary>
[CppInclude("ZoneGraphTestingActor.h")]
public partial class UZoneLaneTest : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>OwnerComponent</summary>
	public UZoneGraphTestingComponent OwnerComponent;
}

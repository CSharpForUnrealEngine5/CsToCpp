#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class to inherit from to be able to perform custom actions on lane detected by the testing actor.</summary>
[CppInclude("ZoneGraphTestingActor.h")]
public partial class UZoneLaneTest : UObject {
	///<summary>OwnerComponent</summary>
	public UZoneGraphTestingComponent OwnerComponent;
}

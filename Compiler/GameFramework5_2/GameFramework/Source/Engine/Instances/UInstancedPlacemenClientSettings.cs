#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings which can be shared across partition actors</summary>
[CppInclude("Instances/InstancedPlacementClientInfo.h")]
public partial class UInstancedPlacemenClientSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>UpdateGuid</summary>
	public FGuid UpdateGuid;
	///<summary>ObjectPath</summary>
	public FSoftObjectPath ObjectPath;
	///<summary>InstancedComponentSettings</summary>
	public FISMComponentDescriptor InstancedComponentSettings;
}

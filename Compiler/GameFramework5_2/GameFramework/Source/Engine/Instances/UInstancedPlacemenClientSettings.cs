#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Instances/InstancedPlacementClientInfo.h")]
///<summary>Settings which can be shared across partition actors</summary>
public partial class UInstancedPlacemenClientSettings : UObject {
// InstancedPlacemenClientSettings
	public FGuid UpdateGuid;
	public FSoftObjectPath ObjectPath;
	public FISMComponentDescriptor InstancedComponentSettings;
}

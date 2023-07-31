#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem managing StateTree assets in Mass</summary>
[CppInclude("MassStateTreeSubsystem.h")]
public partial class UMassStateTreeSubsystem : UWorldSubsystem {
	///<summary>InstanceDataArray</summary>
	public TArray<FMassStateTreeInstanceDataItem> InstanceDataArray;
}

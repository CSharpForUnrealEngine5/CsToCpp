namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem managing StateTree assets in Mass</summary>
[CppInclude("MassStateTreeSubsystem.h")]
public partial class UMassStateTreeSubsystem : UWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>InstanceDataArray</summary>
	public TArray<FMassStateTreeInstanceDataItem> InstanceDataArray;
}

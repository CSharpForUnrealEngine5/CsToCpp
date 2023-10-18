namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A subsystem for handling Signals in Mass</summary>
[CppInclude("MassSignalSubsystem.h")]
public partial class UMassSignalSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>CachedWorld</summary>
	public UWorld CachedWorld;
}

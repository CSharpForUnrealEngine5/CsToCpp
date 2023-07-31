#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlBinding.h")]
public partial struct FRemoteControlInitialBindingContext {
	public TSoftObjectPtr<UClass> SupportedClass;
	public string ComponentName;
	public string SubObjectPath;
	public TSoftObjectPtr<UClass> OwnerActorClass;
	public string OwnerActorName;
}

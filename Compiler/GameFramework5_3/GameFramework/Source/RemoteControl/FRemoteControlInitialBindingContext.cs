namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlBinding.h")]
public partial struct FRemoteControlInitialBindingContext {
	public TSoftObjectPtr<UClass> SupportedClass;
	public FName ComponentName;
	public string SubObjectPath;
	public TSoftObjectPtr<UClass> OwnerActorClass;
	public FName OwnerActorName;
}

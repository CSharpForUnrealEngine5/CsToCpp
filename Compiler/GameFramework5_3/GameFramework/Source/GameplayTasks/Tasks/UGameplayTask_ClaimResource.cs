namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tasks/GameplayTask_ClaimResource.h")]
public partial class UGameplayTask_ClaimResource : UGameplayTask {
	public static UClass StaticClass() {return default;}
	///<summary>ClaimResource</summary>
	public static UGameplayTask_ClaimResource ClaimResource(object /*InTaskOwner*/ InTaskOwner,UClass ResourceClass,byte Priority/*=192*/,FName TaskInstanceName/*=NAME_None*/) { return default; }
	///<summary>ClaimResources</summary>
	public static UGameplayTask_ClaimResource ClaimResources(object /*InTaskOwner*/ InTaskOwner,TArray<UClass> ResourceClasses,byte Priority/*=192*/,FName TaskInstanceName/*=NAME_None*/) { return default; }
}

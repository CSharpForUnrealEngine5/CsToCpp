#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/ContentBundle/ContentBundleEditor.h")]
public partial class UContentBundleUnsavedActorMonitor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>UnsavedActors</summary>
	public TArray<TWeakObjectPtr<AActor>> UnsavedActors;
}

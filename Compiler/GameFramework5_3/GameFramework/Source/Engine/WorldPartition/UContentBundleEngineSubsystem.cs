namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/ContentBundle/ContentBundleEngineSubsystem.h")]
public partial class UContentBundleEngineSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>ContentBundleTypeFactoryClass</summary>
	public TSoftObjectPtr<UClass> ContentBundleTypeFactoryClass;
	///<summary>ContentBundleTypeFactory</summary>
	public UContentBundleTypeFactory ContentBundleTypeFactory;
}

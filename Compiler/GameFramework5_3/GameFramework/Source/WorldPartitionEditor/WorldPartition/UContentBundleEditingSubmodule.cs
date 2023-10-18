namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/ContentBundle/ContentBundleEditorSubsystem.h")]
public partial class UContentBundleEditingSubmodule : UContentBundleEditorSubsystemModule {
	public static UClass StaticClass() {return default;}
	///<summary>EditingContentBundlesStack</summary>
	public TArray<FGuid> EditingContentBundlesStack;
	///<summary>EditingContentBundleGuid</summary>
	public FGuid EditingContentBundleGuid;
}

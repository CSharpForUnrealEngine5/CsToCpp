namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/ContentBundle/ContentBundleDescriptor.h")]
public partial class UContentBundleDescriptor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DisplayName</summary>
	public string DisplayName;
	///<summary>DebugColor</summary>
	public FColor DebugColor;
	///<summary>Guid</summary>
	public FGuid Guid;
	///<summary>PackageRoot</summary>
	public string PackageRoot;
}

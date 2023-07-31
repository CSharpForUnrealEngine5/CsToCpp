#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CodeProjectItem.h")]
public partial class UCodeProjectItem : UObject {
	///<summary>Type</summary>
	public ECodeProjectItemType Type;
	///<summary>Name</summary>
	public string Name;
	///<summary>Extension</summary>
	public string Extension;
	///<summary>Path</summary>
	public string Path;
	///<summary>Children</summary>
	public TArray<UCodeProjectItem> Children;
}

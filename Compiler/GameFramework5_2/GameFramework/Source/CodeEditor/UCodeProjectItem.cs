#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CodeProjectItem.h")]
public partial class UCodeProjectItem : UObject {
// CodeProjectItem
	public byte Type;
	public string Name;
	public string Extension;
	public string Path;
	public TArray<UCodeProjectItem> Children;
}

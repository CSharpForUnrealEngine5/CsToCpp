#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Util/WidgetReference.h")]
///<summary>A reference to any child widget within an UMG Blueprint; only widgets in the same widget tree can be referenced.</summary>
public partial struct FChildWidgetReference {
// ChildWidgetReference
	public TSoftObjectPtr<UWidget> Template;
}

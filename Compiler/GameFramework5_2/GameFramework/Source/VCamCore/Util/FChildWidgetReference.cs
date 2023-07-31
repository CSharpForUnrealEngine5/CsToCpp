#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A reference to any child widget within an UMG Blueprint; only widgets in the same widget tree can be referenced.</summary>
[CppInclude("Util/WidgetReference.h")]
public partial struct FChildWidgetReference {
	public TSoftObjectPtr<UWidget> Template;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavLinkDefinition.h")]
///<summary>Class containing definition of a navigation area</summary>
public partial class UNavLinkDefinition : UObject {
// NavLinkDefinition
	public TArray<FNavigationLink> Links;
	public TArray<FNavigationSegmentLink> SegmentLinks;
}

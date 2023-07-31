#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class containing definition of a navigation area</summary>
[CppInclude("AI/Navigation/NavLinkDefinition.h")]
public partial class UNavLinkDefinition : UObject {
	///<summary>Links</summary>
	public TArray<FNavigationLink> Links;
	///<summary>SegmentLinks</summary>
	public TArray<FNavigationSegmentLink> SegmentLinks;
}

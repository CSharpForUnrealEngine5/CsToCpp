namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavLinkComponent.h")]
public partial class UNavLinkComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Links</summary>
	public TArray<FNavigationLink> Links;
}

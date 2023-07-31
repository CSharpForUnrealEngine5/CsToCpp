#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@TODO: this can encapsulate globally defined fields as well (like with native</summary>
[CppInclude("Engine/MemberReference.h")]
public partial struct FMemberReference {
	public UObject MemberParent;
	public string MemberScope;
	public string MemberName;
	public FGuid MemberGuid;
	public bool bSelfContext;
	public bool bWasDeprecated;
}

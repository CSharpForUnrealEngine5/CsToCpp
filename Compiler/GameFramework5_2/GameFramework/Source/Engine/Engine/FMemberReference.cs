#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MemberReference.h")]
///<summary>@TODO: this can encapsulate globally defined fields as well (like with native</summary>
public partial struct FMemberReference {
// MemberReference
	public UObject MemberParent;
	public string MemberScope;
	public string MemberName;
	public FGuid MemberGuid;
	public bool bSelfContext;
	public bool bWasDeprecated;
}

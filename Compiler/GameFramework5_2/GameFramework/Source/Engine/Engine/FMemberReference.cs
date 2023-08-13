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

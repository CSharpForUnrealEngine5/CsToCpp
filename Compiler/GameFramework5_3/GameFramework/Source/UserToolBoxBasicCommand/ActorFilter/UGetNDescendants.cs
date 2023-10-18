namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFilter/BaseActorFilter.h")]
public partial class UGetNDescendants : UBaseActorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>N</summary>
	public int N;
	///<summary>AddIntermediaries</summary>
	public bool AddIntermediaries;
}

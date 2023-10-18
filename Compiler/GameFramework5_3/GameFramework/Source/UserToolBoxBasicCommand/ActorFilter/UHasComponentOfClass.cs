namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFilter/BaseActorFilter.h")]
public partial class UHasComponentOfClass : UBaseActorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>ComponentClass</summary>
	public UClass ComponentClass;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFilter/BaseActorFilter.h")]
public partial class UIsClassOf : UBaseActorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>ActorClass</summary>
	public UClass ActorClass;
	///<summary>ChildClass</summary>
	public bool ChildClass;
}

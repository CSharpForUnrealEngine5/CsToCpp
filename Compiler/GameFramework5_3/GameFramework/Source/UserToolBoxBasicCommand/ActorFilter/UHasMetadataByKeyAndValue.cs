namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorFilter/BaseActorFilter.h")]
public partial class UHasMetadataByKeyAndValue : UBaseActorFilter {
	public static UClass StaticClass() {return default;}
	///<summary>Key</summary>
	public FName Key;
	///<summary>Value</summary>
	public string Value;
}

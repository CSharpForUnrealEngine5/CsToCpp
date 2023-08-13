namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SelectActorByFilter.h")]
public partial class USelectActorByFilter : UUTBBaseCommand {
	public static UClass StaticClass() {return default;}
	///<summary>ApplyToCurrentSelection</summary>
	public bool ApplyToCurrentSelection;
	///<summary>FilterStack</summary>
	public TArray<FActorFilterOptions> FilterStack;
}

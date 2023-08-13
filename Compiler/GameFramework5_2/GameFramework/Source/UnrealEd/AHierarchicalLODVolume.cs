namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An invisible volume used to manually define/create an HLOD cluster.</summary>
[CppInclude("HierarchicalLODVolume.h")]
public partial class AHierarchicalLODVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>When set this volume will incorporate actors which bounds overlap with the volume, otherwise only actors which are completely inside of the volume are incorporated</summary>
	public bool bIncludeOverlappingActors;
	///<summary>If set, this volume will only be applied to HLOD levels contained in the array.  If empty, it will apply to ALL HLOD levels</summary>
	public TArray<int> ApplyOnlyToSpecificHLODLevels;
}

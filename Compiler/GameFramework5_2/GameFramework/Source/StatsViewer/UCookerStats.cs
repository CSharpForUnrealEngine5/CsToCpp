namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Statistics for a cooked asset.</summary>
[CppInclude("CookerStats.h")]
public partial class UCookerStats : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The assets contained in the file.</summary>
	public TArray<TWeakObjectPtr<UObject>> Assets;
	///<summary>The size of the assets before cooking.</summary>
	public float SizeBefore;
	///<summary>The size of the assets after cooking.</summary>
	public float SizeAfter;
	///<summary>Asset path without the name &quot;package.[group.]&quot;</summary>
	public string Path;
}

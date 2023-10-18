namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings giving additional control over geometry resampling + related visualization</summary>
[CppInclude("FractureToolResample.h")]
public partial class UFractureResampleSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to visualize all mesh vertices or only the ones added by resampling</summary>
	public bool bOnlyShowAddedPoints;
}

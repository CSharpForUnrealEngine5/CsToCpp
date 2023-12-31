namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CullDistanceVolume.h")]
public partial class ACullDistanceVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>Array of size and cull distance pairs. The code will calculate the sphere diameter of a primitive&#39;s BB and look for a best</summary>
	public TArray<FCullDistanceSizePair> CullDistances;
	///<summary>Whether the volume is currently enabled or not.</summary>
	public bool bEnabled;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Builds a collection of landscape data from the selected actors.</summary>
[CppInclude("Elements/PCGTypedGetter.h")]
public partial class UPCGGetLandscapeSettings : UPCGDataFromActorSettings {
	public static UClass StaticClass() {return default;}
	///<summary>bGetHeightOnly</summary>
	public bool bGetHeightOnly;
	///<summary>bGetLayerWeights</summary>
	public bool bGetLayerWeights;
}

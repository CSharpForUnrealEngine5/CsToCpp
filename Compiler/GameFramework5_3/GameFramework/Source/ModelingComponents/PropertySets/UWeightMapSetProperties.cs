namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Basic Tool Property Set that allows for selecting from a list of FNames (that we assume are Weight Maps)</summary>
[CppInclude("PropertySets/WeightMapSetProperties.h")]
public partial class UWeightMapSetProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Select vertex weight map. If configured, the weight map value will be sampled to modulate displacement intensity.</summary>
	public FName WeightMap;
	///<summary>this function is called provide set of available weight maps</summary>
	public TArray<string> GetWeightMapsFunc() { return default; }
	///<summary>internal list used to implement above</summary>
	public TArray<string> WeightMapsList;
	///<summary>bInvertWeightMap</summary>
	public bool bInvertWeightMap;
}

namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for Histogram configuration. *</summary>
[CppInclude("SGeometryCollectionHistogram.h")]
public partial class UHistogramSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>What attribute are we inspecting?</summary>
	public EInspectedAttributeEnum InspectedAttribute;
	///<summary>Sort the values?</summary>
	public bool bSorted;
	///<summary>Show clusters?</summary>
	public bool bShowClusters;
	///<summary>Show rigids?</summary>
	public bool bShowRigids;
	///<summary>Show embedded geometry?</summary>
	public bool bShowEmbedded;
}

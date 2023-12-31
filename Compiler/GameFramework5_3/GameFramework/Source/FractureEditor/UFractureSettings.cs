namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings specifically related to viewing fractured meshes *</summary>
[CppInclude("FractureSettings.h")]
public partial class UFractureSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Amount to expand the displayed Geometry Collection bones into an &#39;exploded view&#39;</summary>
	public float ExplodeAmount;
	///<summary>Current level of the Geometry Collection displayed</summary>
	public int FractureLevel;
	///<summary>When active, only show selected bones</summary>
	public bool bHideUnselected;
	///<summary>RestCollection</summary>
	public TWeakObjectPtr<UGeometryCollection> RestCollection;
}

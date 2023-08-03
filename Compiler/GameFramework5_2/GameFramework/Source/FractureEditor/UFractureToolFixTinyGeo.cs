#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note this tool doesn&#39;t actually fracture, but it does remake pieces of geometry and shares a lot of machinery with the fracture tools</summary>
[CppInclude("FractureToolFixTinyGeo.h")]
public partial class UFractureToolFixTinyGeo : UFractureToolCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>TinyGeoSettings</summary>
	public UFractureTinyGeoSettings TinyGeoSettings;
}

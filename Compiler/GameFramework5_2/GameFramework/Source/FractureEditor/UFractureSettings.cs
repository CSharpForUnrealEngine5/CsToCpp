#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings specifically related to viewing fractured meshes *</summary>
[CppInclude("FractureSettings.h")]
public partial class UFractureSettings : UObject {
	///<summary>Amount to expand the displayed Geometry Collection bones into an &#39;exploded view&#39;</summary>
	public float ExplodeAmount;
	///<summary>Current level of the Geometry Collection displayed</summary>
	public int FractureLevel;
	///<summary>When active, only show selected bones</summary>
	public bool bHideUnselected;
}

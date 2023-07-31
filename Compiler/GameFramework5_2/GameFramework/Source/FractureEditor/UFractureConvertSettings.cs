#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings related to geometry collection -&gt; static mesh conversion *</summary>
[CppInclude("FractureToolConvert.h")]
public partial class UFractureConvertSettings : UFractureToolSettings {
	///<summary>Whether to prompt user for a location and base name for the generated meshes, or automatically place them next to the source geometry collections</summary>
	public bool bPromptForBaseName;
	///<summary>Whether to generate a separate mesh for each bone, or one combined mesh</summary>
	public bool bPerBone;
	///<summary>Whether to center the pivot for each mesh, or use the pivot from the geometry collection</summary>
	public bool bCenterPivots;
	///<summary>Whether to place new static mesh actors in the level</summary>
	public bool bPlaceInWorld;
	///<summary>Whether to select new static mesh actors</summary>
	public bool bSelectNewActors;
}

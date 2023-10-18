namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure holding data to associate lane densities to</summary>
[CppInclude("MassCrowdSettings.h")]
public partial struct FMassCrowdLaneDensityDesc {
	public FZoneGraphTag Tag;
	public float Weight;
	public FColor RenderColor;
}

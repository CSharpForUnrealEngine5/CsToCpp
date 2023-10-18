namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UV Layout Settings</summary>
[CppInclude("Properties/UVLayoutProperties.h")]
public partial class UUVLayoutProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Type of layout applied to input UVs</summary>
	public EUVLayoutType LayoutType;
	///<summary>Expected resolution of the output textures; this controls spacing left between UV islands to avoid interpolation artifacts</summary>
	public int TextureResolution;
	///<summary>Uniform scale applied to UVs after packing</summary>
	public float Scale;
	///<summary>Translation applied to UVs after packing, and after scaling</summary>
	public FVector2D Translation;
	///<summary>Allow the Repack layout type to flip the orientation of UV islands to save space. Note that this may cause problems for downstream operations, and therefore is disabled by default.</summary>
	public bool bAllowFlips;
	///<summary>Enable UDIM aware layout and keep islands within their originating UDIM tiles when laying out.</summary>
	public bool bEnableUDIMLayout;
	///<summary>bUDIMCVAREnabled</summary>
	public bool bUDIMCVAREnabled;
}

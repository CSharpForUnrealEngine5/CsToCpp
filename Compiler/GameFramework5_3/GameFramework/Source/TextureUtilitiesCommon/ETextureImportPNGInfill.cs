namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureImportSettings.h")]
///<summary>When should RGB colors be spread into neighboring fully transparent white pixels, replacing their RGB.</summary>
public enum ETextureImportPNGInfill {
	Default=0,
	Never=1,
	OnlyOnBinaryTransparency=2,
	Always=3,
}

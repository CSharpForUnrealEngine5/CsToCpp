#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Encoding can either use the &quot;Final&quot; or &quot;Fast&quot; speeds, for supported encoders (e.g. Oodle)</summary>
[CppInclude("TextureEncodingSettings.h")]
public partial class UTextureEncodingProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If true, Final encode speed enables rate-distortion optimization on supported encoders to</summary>
	public bool bFinalUsesRDO;
	///<summary>Ignored if UsesRDO is false. This value is used if a given texture is using &quot;Default&quot; LossyCompressionAmount.</summary>
	public short FinalRDOLambda;
	///<summary>Specifies how much time to take trying for better encoding results.</summary>
	public ETextureEncodeEffort FinalEffortLevel;
	///<summary>Specifies how to assume textures are laid out on disc. This only applies to Oodle with RDO</summary>
	public ETextureUniversalTiling FinalUniversalTiling;
	///<summary>If true, Final encode speed enables rate-distortion optimization on supported encoders to</summary>
	public bool bFastUsesRDO;
	///<summary>Ignored if UsesRDO is false. This value is used if a given texture is using &quot;Default&quot; LossyCompressionAmount.</summary>
	public short FastRDOLambda;
	///<summary>Specifies how much time to take trying for better encode results.</summary>
	public ETextureEncodeEffort FastEffortLevel;
	///<summary>Specifies how to assume textures are laid out on disc. This only applies to Oodle with RDO</summary>
	public ETextureUniversalTiling FastUniversalTiling;
	///<summary>Which encode speed non interactive editor sessions will use (i.e. commandlets)</summary>
	public ETextureEncodeSpeed CookUsesSpeed;
	///<summary>Which encode speed everything else uses.</summary>
	public ETextureEncodeSpeed EditorUsesSpeed;
}

#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureEncodingSettings.h")]
///<summary>Encoding can either use the "Final" or "Fast" speeds, for supported encoders (e.g. Oodle)</summary>
public partial class UTextureEncodingProjectSettings : UDeveloperSettings {
// TextureEncodingProjectSettings
	public bool bFinalUsesRDO;
	public short FinalRDOLambda;
	public ETextureEncodeEffort FinalEffortLevel;
	public ETextureUniversalTiling FinalUniversalTiling;
	public bool bFastUsesRDO;
	public short FastRDOLambda;
	public ETextureEncodeEffort FastEffortLevel;
	public ETextureUniversalTiling FastUniversalTiling;
	public ETextureEncodeSpeed CookUsesSpeed;
	public ETextureEncodeSpeed EditorUsesSpeed;
}

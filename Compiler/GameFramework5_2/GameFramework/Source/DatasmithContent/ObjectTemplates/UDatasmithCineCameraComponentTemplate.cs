namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectTemplates/DatasmithCineCameraComponentTemplate.h")]
public partial class UDatasmithCineCameraComponentTemplate : UDatasmithObjectTemplate {
	public static UClass StaticClass() {return default;}
	///<summary>FilmbackSettings</summary>
	public FDatasmithCameraFilmbackSettingsTemplate FilmbackSettings;
	///<summary>LensSettings</summary>
	public FDatasmithCameraLensSettingsTemplate LensSettings;
	///<summary>FocusSettings</summary>
	public FDatasmithCameraFocusSettingsTemplate FocusSettings;
	///<summary>CurrentFocalLength</summary>
	public float CurrentFocalLength;
	///<summary>CurrentAperture</summary>
	public float CurrentAperture;
	///<summary>PostProcessSettings</summary>
	public FDatasmithPostProcessSettingsTemplate PostProcessSettings;
}

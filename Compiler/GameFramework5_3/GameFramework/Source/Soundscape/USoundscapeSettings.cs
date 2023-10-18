namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSettings.h")]
public partial class USoundscapeSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Soundscape Palette Collection</summary>
	public TSet<FSoftObjectPath> SoundscapePaletteCollection;
	///<summary>bDebugDraw</summary>
	public bool bDebugDraw;
	///<summary>Hash Cell Width for LOD1</summary>
	public float LOD1ColorPointHashWidth;
	///<summary>Hash Cell LOD1 Max Distance</summary>
	public float LOD1ColorPointHashDistance;
	///<summary>Hash Cell Width for LOD2</summary>
	public float LOD2ColorPointHashWidth;
	///<summary>Hash Cell LOD2 Max Distance</summary>
	public float LOD2ColorPointHashDistance;
	///<summary>Hash Cell Width for LOD3</summary>
	public float LOD3ColorPointHashWidth;
	///<summary>Hash Cell Width for the Active Hash</summary>
	public float ActiveColorPointHashWidth;
	///<summary>Hash Cell Update Timing for the Active Hash</summary>
	public float ActiveColorPointHashUpdateTimeSeconds;
}

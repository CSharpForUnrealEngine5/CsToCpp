namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeSubsystem.h")]
public partial class USoundscapeColorPointHashMapCollection : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Color Point Hash Maps</summary>
	public USoundscapeColorPointHashMap ColorPointHashMapLOD1;
	///<summary>ColorPointHashMapLOD2</summary>
	public USoundscapeColorPointHashMap ColorPointHashMapLOD2;
	///<summary>ColorPointHashMapLOD3</summary>
	public USoundscapeColorPointHashMap ColorPointHashMapLOD3;
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
}

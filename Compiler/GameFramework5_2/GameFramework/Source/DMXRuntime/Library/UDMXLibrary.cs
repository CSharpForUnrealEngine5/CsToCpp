namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Library/DMXLibrary.h")]
public partial class UDMXLibrary : UDMXObjectBase {
	public static UClass StaticClass() {return default;}
	///<summary>Input ports of the Library</summary>
	public FDMXLibraryPortReferences PortReferences;
	///<summary>All Fixture Types and Fixture Patches in the Library</summary>
	public TArray<UDMXEntity> Entities;
	///<summary>The General Scene Description of this Library</summary>
	public UDMXMVRGeneralSceneDescription GeneralSceneDescription;
}

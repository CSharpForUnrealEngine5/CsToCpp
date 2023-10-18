namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom class deriving from UStaticMeshComponent to allow the display of individual meshes in wireframe</summary>
[CppInclude("Widgets/SDataprepEditorViewport.h")]
public partial class UCustomStaticMeshComponent : UStaticMeshComponent {
	public static UClass StaticClass() {return default;}
}

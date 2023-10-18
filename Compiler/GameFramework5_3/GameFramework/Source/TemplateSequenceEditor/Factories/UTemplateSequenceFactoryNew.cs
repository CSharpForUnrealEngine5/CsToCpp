namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a factory for UTemplateSequence objects.</summary>
[CppInclude("Factories/TemplateSequenceFactoryNew.h")]
public partial class UTemplateSequenceFactoryNew : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The root object binding class of the created template sequence.</summary>
	public UClass BoundActorClass;
}

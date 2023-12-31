namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DocumentationActor.h")]
public partial class ADocumentationActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Link to a help document.</summary>
	public string DocumentLink;
	///<summary>Billboard</summary>
	public UMaterialBillboardComponent Billboard;
}

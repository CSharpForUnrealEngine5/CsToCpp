namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Override this class in order to make an additional front-end filter available in the Content Browser</summary>
[CppInclude("ContentBrowserFrontEndFilterExtension.h")]
public partial class UContentBrowserFrontEndFilterExtension : UObject {
	public static UClass StaticClass() {return default;}
}

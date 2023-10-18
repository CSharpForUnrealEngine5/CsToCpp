namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassObserverProcessor.h")]
public partial class UMassObserverProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>bAutoRegisterWithObserverRegistry</summary>
	public bool bAutoRegisterWithObserverRegistry;
	///<summary>Determines which Fragment or Tag type this given UMassObserverProcessor will be observing</summary>
	public UScriptStruct ObservedType;
}

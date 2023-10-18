namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialLayersFunctions.h")]
public enum EMaterialLayerLinkState {
	Uninitialized=0,
	LinkedToParent=1,
	UnlinkedFromParent=2,
	NotFromParent=3,
}

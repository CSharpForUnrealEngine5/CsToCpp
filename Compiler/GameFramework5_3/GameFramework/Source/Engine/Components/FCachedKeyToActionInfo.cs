namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct that exists to store runtime cache to make key to action lookups faster.</summary>
[CppInclude("Components/InputComponent.h")]
public partial struct FCachedKeyToActionInfo {
	public TWeakObjectPtr<UPlayerInput> PlayerInput;
}

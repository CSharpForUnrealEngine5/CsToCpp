#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InputComponent.h")]
///<summary>Struct that exists to store runtime cache to make key to action lookups faster.</summary>
public partial struct FCachedKeyToActionInfo {
// CachedKeyToActionInfo
	public TWeakObjectPtr<UPlayerInput> PlayerInput;
}

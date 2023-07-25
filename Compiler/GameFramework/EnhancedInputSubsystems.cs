using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("EnhancedInputSubsystems.h")]
    public partial class UEnhancedInputLocalPlayerSubsystem : ULocalPlayerSubsystem {
        public virtual void AddMappingContext(UInputMappingContext MappingContext, int Priority) {}
        public virtual void RemoveMappingContext(UInputMappingContext MappingContext) { }
    }

    [CppInclude("EnhancedInputSubsystems.h")]
    public partial class UEnhancedInputWorldSubsystem : UWorldSubsystem {
    }

}
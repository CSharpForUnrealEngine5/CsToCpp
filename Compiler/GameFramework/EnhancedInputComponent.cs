using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("EnhancedInputComponent.h")]
    public partial class UEnhancedInputComponent : UInputComponent {

        public delegate void SimpleAction();
        public delegate void InputAction(FInputActionValue a);
        public void BindAction(UInputAction action, ETriggerEvent e, Object target, string a) { }
        //public void BindAction(UInputAction action, ETriggerEvent e, Object target, SimpleAction a) { }
        //public void BindAction(UInputAction action, ETriggerEvent e, Object target, InputAction a) { }
    }

}
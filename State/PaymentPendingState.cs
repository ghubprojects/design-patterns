namespace State;

public class PaymentPendingState : IVendingMachineState {
    public void HandleRequest() {
        Console.WriteLine("Payment pending state: Dispensing product.");
    }
}
namespace State;

public class ProductSelectedState : IVendingMachineState {
    public void HandleRequest() {
        Console.WriteLine("Product selected state: Processing payment.");
    }
}
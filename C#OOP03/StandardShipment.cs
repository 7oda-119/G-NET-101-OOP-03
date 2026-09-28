namespace C_OOP03
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight, double deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment
        {
        }
    }
}

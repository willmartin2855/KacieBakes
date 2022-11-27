namespace DougExamples
{
    public class Car : AbstractVehicle
    {
        public string Color { get; set; }
        private string VinNumber { get; set; }

        public Car(string vin)
        {
            VinNumber = vin ?? throw new ArgumentNullException(nameof(vin));
        }

        public void VerifyInsurance()
        {
            if (!VinNumber.Any())
                throw new NotImplementedException();
        }
    }
}

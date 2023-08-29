
namespace PagamentoServiço.Entities {
    internal class OutsourcedEmployee : Employee {
        // Herda todos os atributos do Employee
        public double AdditionalCharger { get; set; }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharger)
            /* recebe os dados name, hours.... porem com o ( : base() ) em baixo aproveitas os dados ja
             * colocados no Employee, restando somente a acreçao do additionalCharger.
            */
            : base(name, hours, additionalCharger)
        {
            AdditionalCharger = additionalCharger;
        }

        public override double Payment()
        // override e´usado para aproveitar os atributos do Payment do Employee.
        {
            return base.Payment() + 1.1 * AdditionalCharger;
            //Feito somente a adiçao da operaçao + 1.1 * AdditionalCharger
        }
    }
}

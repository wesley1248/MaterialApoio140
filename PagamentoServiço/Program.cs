using PagamentoServiço.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagamentoServiço {
    internal class Program {
        static void Main(string[] args)
        {
            List<Employee> List = new List<Employee>();
            // decalrou  a lista employee 

            Console.Write("Enter the number of employees: ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroFuncionarios; i++)
            // laço para repetir a quantidade de funcionarios.
            {

                Console.WriteLine($"Employee #{i} data: ");
                Console.WriteLine();
                Console.WriteLine("Outsourced (y/n)?: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (ch == 'y')
                // se a reposta for sim para funcionario tercerizado
                {
                    Console.Write("Additional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    // o atributo carga adicional é adionado 

                    List.Add(new OutsourcedEmployee { Name = name, Hours = hours, ValuePerHour = valuePerHours, AdditionalCharger = addicionalCharge });
                    /* é adicionado a lista(linha 13) um obejto do funcionario tercerizado
                     * OutsourcedEmployee com a adiçao addicionalCharge carga adicional
                     */
                }
                else
                {
                    List.Add(new Employee { Name = name, Hours = hours, ValuePerHour = valuePerHours });
                    // se for um funcionario normal ele instancia um objeto do funcionario normal Employee
                        // e adiciona os dados na lista.
                }
            }

            Console.WriteLine();

            Console.WriteLine("Payment");
            foreach (Employee funcionarios in List)
            {
                Console.WriteLine("Nome: " + funcionarios.Name + " - $" + funcionarios.Payment().ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}

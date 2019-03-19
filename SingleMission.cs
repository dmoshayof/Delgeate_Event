using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
     
        
        public delegate double singleDel(double num);
        private singleDel mission;
        public string Name { get ; }
        public string Type { get; }

        public SingleMission(Func<double,double> func, string name) {
            Name = name;
            Type = "Single Mission";
            mission = new singleDel(func);
        }


        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            value = mission.Invoke(value);
            OnCalculate?.Invoke(this, value);
            return value;
        }
    }
}
